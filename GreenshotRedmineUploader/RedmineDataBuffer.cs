/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 20.12.2012
 * Time: 2:18 
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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.IsolatedStorage;

namespace GreenshotRedmineUploader
{
	[Serializable]
	public class RedmineIssueStorage 
	{
		public int id;
		public string tracker;
		public string subject;
		public string project;
		public int projectid;
		
		public RedmineIssueStorage(int _id, string _tracker, string _subject, string _project, int _projectid) {
			id = _id;
			tracker = _tracker;
			subject = _subject;
			project = _project;
			projectid = _projectid;
		}
		
		public RedmineIssueStorage(Issue issue) {
			id = issue.Id;
			tracker = issue.Tracker.Name;
			subject = issue.Subject;
			project = issue.Project.Name;
			projectid = issue.Project.Id;
		}
	}
	
	
	/// <summary>
	/// Redmine Settings stores the complete cached informations of the used redmine system and some settings of the connection
	/// </summary>
	[Serializable]
	public class RedmineDataBuffer
	{
		public string host;
		public string apikey;
		
		public SortedDictionary<string,int> projects;
		public SortedDictionary<string,int> priorities;
		public SortedDictionary<string,int> trackers;
		public SortedDictionary<string,int> statuses;
		public SortedDictionary<string,int> users;
		public SortedDictionary<int,RedmineIssueStorage> issues;
		public SortedDictionary<string,int> currentIssues;
		public SortedDictionary<string,int> allIssues;
		public int defaultProject;
		public int defaultTracker;
		public int defaultPriority;
		public int defaultStatus;
		public string defaultSubject;
		
		public bool closeAfterUpload;	
		public bool onlyImportOpenVersions;
		
		public RedmineDataBuffer() {
			projects = new SortedDictionary<string,int>();
			priorities = new SortedDictionary<string,int>();
			trackers = new SortedDictionary<string,int>();
			statuses = new SortedDictionary<string,int>();
			issues = new SortedDictionary<int,RedmineIssueStorage>();
			trackers = new SortedDictionary<string,int>();
			currentIssues = new SortedDictionary<string,int>();
			allIssues = new SortedDictionary<string,int>();
			defaultProject = 0;
			defaultTracker = 0;
			defaultPriority = 0;
			defaultStatus = 0;
			host = "";
			apikey = "";
			closeAfterUpload = true;
			onlyImportOpenVersions = false;
			defaultSubject = "";
		}
		
		private static string filename = "GreenshotRedmineUploader.data";


		public bool Save(){
        	 IsolatedStorageFile isf  = IsolatedStorageFile.GetStore(IsolatedStorageScope.User|
        										IsolatedStorageScope.Assembly|IsolatedStorageScope.Domain, 
        										typeof(System.Security.Policy.Url),typeof(System.Security.Policy.Url));
			try {
			    IsolatedStorageFileStream theStream;
                theStream = new IsolatedStorageFileStream(filename, FileMode.Create, isf);

				
				BinaryFormatter theFormatter = new BinaryFormatter();
				theFormatter.Serialize(theStream, this);
				theStream.Dispose();
				theStream.Close();
			} catch (Exception e){
				MessageBox.Show(e.Message,"Error");
				return false;
			}
			return true;
			
		}
		
		public static RedmineDataBuffer Read(){
			RedmineDataBuffer theReturn = null;
			try {
				 IsolatedStorageFile isf  = IsolatedStorageFile.GetStore(IsolatedStorageScope.User|
        										IsolatedStorageScope.Assembly|IsolatedStorageScope.Domain, 
        										typeof(System.Security.Policy.Url),typeof(System.Security.Policy.Url));
				IsolatedStorageFileStream theStream;
                theStream = new IsolatedStorageFileStream(filename, FileMode.Open, isf);

				BinaryFormatter theFormatter = new BinaryFormatter();
				theReturn = (RedmineDataBuffer)theFormatter.Deserialize(theStream);
				theStream.Dispose();
				theStream.Close();
			}
			catch {
				return null;
			}
			
			//Backward compatibility: Some may use old save files and we need some initialized dataset:
			if (theReturn.projects == null) {
				theReturn.projects = new SortedDictionary<string,int>();
			}
			if (theReturn.priorities == null) {
				theReturn.priorities = new SortedDictionary<string,int>();
			}
			if (theReturn.trackers == null) {
				theReturn.trackers = new SortedDictionary<string,int>();
			}
			if (theReturn.issues == null) {
				theReturn.issues = new SortedDictionary<int,RedmineIssueStorage>();
			}
			if (theReturn.trackers == null) {
				theReturn.trackers = new SortedDictionary<string,int>();
			}
			if (theReturn.currentIssues == null) {
				theReturn.currentIssues = new SortedDictionary<string,int>();
			}
			if (theReturn.allIssues == null) {
				theReturn.allIssues = new SortedDictionary<string,int>();
			}
			if (theReturn.statuses == null) {
				theReturn.statuses = new SortedDictionary<string,int>();
			}
			
			return theReturn;
		}	

	}
	
}
