/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 3:33 
 * 
 *  Copyright Michael Kling - Ascendro S.R.L
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */
using System;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace GreenshotRedmineUploader
{
	public class RedmineSettings 
	{				
		public RedmineDataBuffer buffer;
		
		private RedmineManager manager;
		public RedmineSettings()
		{
			buffer = RedmineDataBuffer.Read();
			if (buffer == null) {
				//means no settings where saved until now...
				buffer = new RedmineDataBuffer();
			}
			manager = null;
		}
		
		public void resetConnection() {
			manager = null;			
		}
		
		private RedmineManager getManager() {
			if (manager == null) {
				try {
					manager = new RedmineManager(buffer.host, buffer.apikey);
				} catch (Redmine.Net.Api.RedmineException e) {
					MessageBox.Show(e.Message,"Connection Error.");
					manager = null;
				}
			}
			return manager;			
		}
				
		public bool syncWithRed() {
			buffer.projects.Clear();
			buffer.trackers.Clear();
			buffer.priorities.Clear();
			buffer.statuses.Clear();
			buffer.trackers.Clear();
			
			try {
				var parameters = new NameValueCollection {{"include", "memberships"}};
				var currentUser = getManager().GetCurrentUser(parameters);				
				foreach (var membership in currentUser.Memberships) {
					buffer.projects.Add(membership.Project.Name,membership.Project.Id);            								
				}		
				
				
				parameters = new NameValueCollection {};
	            foreach (var tracker in getManager().GetObjectList<Tracker>(parameters))
	            {
	            	buffer.trackers.Add(tracker.Name,tracker.Id);
	            }
	            
	            //Maybe in the future we can request the enums.            
	            buffer.priorities.Add("Very low",5);
	            buffer.priorities.Add("Low",1);
	            buffer.priorities.Add("Normal",2);
	            buffer.priorities.Add("High",3);
	            buffer.priorities.Add("Critical",4);
	            buffer.priorities.Add("Default",0);
	                      
				parameters = new NameValueCollection {};
	            foreach (var status in getManager().GetObjectList<IssueStatus>(parameters))
	            {
	            	buffer.statuses.Add(status.Name,status.Id);            	
	            }
	            buffer.statuses.Add("Default",0);
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while Syncing.");
				buffer.projects.Clear();
				buffer.trackers.Clear();
				buffer.priorities.Clear();
				buffer.statuses.Clear();
				buffer.trackers.Clear();
				return false;
			}        
			syncIssueList();
			return true;
		}
		
		public bool getCurrentList(int projectId) {
			buffer.currentIssues.Clear();
			foreach (int key in buffer.issues.Keys) {
				RedmineIssueStorage issue = (RedmineIssueStorage)buffer.issues[key];
				if (projectId == issue.projectid) {
					buffer.currentIssues.Add(issue.tracker+" - "+issue.subject+" ("+issue.id+")",issue.id);
				}		
			}			
			return true;
		}
		
		public bool syncIssueList() {
			buffer.issues.Clear();	
			buffer.allIssues.Clear();
			buffer.currentIssues.Clear();
			try {
				int offset = 0;
				IList<Issue> issuePage = null;
				do {					
					var parameters = new NameValueCollection {{"sort", "project%2Ctracker%2Cproject"},{"offset",offset.ToString()},{"limit","100"}};
					issuePage = getManager().GetObjectList<Issue>(parameters);
					
					foreach (var issue in issuePage) {
						RedmineIssueStorage storage = new RedmineIssueStorage((Issue)issue);
						buffer.issues.Add(issue.Id, storage);
						buffer.allIssues.Add(issue.Project.Name+" - "+issue.Tracker.Name+" - "+issue.Subject+" ("+issue.Id+")",issue.Id);						
					}	
					offset = offset + issuePage.Count;
				} while(issuePage.Count > 0);
				
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while Syncing.");
				buffer.issues.Clear();
				buffer.allIssues.Clear();
				buffer.currentIssues.Clear();
				return false;
			}             
			return true;
		}
		
		public Issue getPlainIssue(string issueId) {	
			var parameters = new NameValueCollection {};
			Issue issue = null;
			try {
		 		issue = getManager().GetObject<Issue>(issueId,parameters);
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while checking issue.");
			}
			return issue;
		}
		
		
		public Hashtable getProjectAssigneeList(string projectId) {
			Hashtable assigneeList = new Hashtable();
			assigneeList.Add("No Change",null);
			try {
				var parameters = new NameValueCollection {{"project_id", projectId}};
				foreach (var member in getManager().GetObjectList<ProjectMembership>(parameters))
	            {
					if (member.User != null) {
						assigneeList.Add(member.User.Name,member.User.Id);
					} else {
						assigneeList.Add(member.Group.Name,member.Group.Id);
					}
	            }
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while checking assignee list.");
			}
			return assigneeList;			
		}
		
		public Hashtable getProjectVersionList(string projectId) {
			Hashtable versionList = new Hashtable();
			versionList.Add("No Change",null);
			try {
				var parameters = new NameValueCollection {{"project_id", projectId}};
				foreach (var version in getManager().GetObjectList<Redmine.Net.Api.Types.Version>(parameters))
	            {
					versionList.Add(version.Name,version.Id);
	            }
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while checking version list.");
			}
			return versionList;		
		}
		
		public Hashtable getProjectCategoryList(string projectId) {
			Hashtable categoryList = new Hashtable();
			categoryList.Add("No Change",null);
			try {
				var parameters = new NameValueCollection {{"project_id", projectId}};
				foreach (var category in getManager().GetObjectList<IssueCategory>(parameters))
	            {
					categoryList.Add(category.Name,category.Id);
	            }
			} catch (Redmine.Net.Api.RedmineException e) {
				MessageBox.Show(e.Message,"Error while checking category list.");
			}
			return categoryList;
		}		
		
		public Upload uploadFile(string filename) {
			//Upload data is not attaching any authorisation keys... so we need to implement it by ourself.
			return getManager().UploadData(FileToByteArray(filename));
		}
		
		public Issue getIssue(string Id) {
			var parameters = new NameValueCollection {{"include","journals,changesets"}};
			return getManager().GetObject<Issue>(Id,parameters);
		}
		
		public Issue createIssue(Issue issue) {
			return getManager().CreateObject<Issue>(issue);
		}
		
		public Journal createJournal(Journal journal,Issue issue) {
			return getManager().CreateObject<Journal>(journal);
		}
		   
		public void updateIssue(Issue issue) {
			getManager().UpdateObject<Issue>(issue.Id.ToString(),issue);
		}
		
        /// <summary>
		/// Function to get byte array from a file
		/// </summary>
		/// <param name="_FileName">File name to get byte array</param>
		/// <returns>Byte Array</returns>
		private byte[] FileToByteArray(string _FileName)
		{
		    byte[] _Buffer = null;
		
	        // Open file for reading
	        System.IO.FileStream _FileStream = new System.IO.FileStream(_FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
	        
	        // attach filestream to binary reader
	        System.IO.BinaryReader _BinaryReader = new System.IO.BinaryReader(_FileStream);
	        
	        // get total byte length of the file
	        long _TotalBytes = new System.IO.FileInfo(_FileName).Length;
	        
	        // read entire file into buffer
	        _Buffer = _BinaryReader.ReadBytes((Int32)_TotalBytes);
	        
	        // close file reader
	        _FileStream.Close();
	        _FileStream.Dispose();
	        _BinaryReader.Close();
		
		    return _Buffer;
		}
		
	}
}
