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

	/// <summary>
	/// Redmine Settings stores the complete cached informations of the used redmine system and some settings of the connection
	/// </summary>
	[Serializable]
	public class RedmineDataBuffer
	{
		public string host;
		public string apikey;
		
		public Hashtable projects;
		public Hashtable priorities;
		public Hashtable trackers;
		public Hashtable statuses;
		public Hashtable users;
		public Hashtable issues;
		public Hashtable currentIssues;
		public int defaultProject;
		public int defaultTracker;
		public int defaultPriority;
		public int defaultStatus;
		public string defaultSubject;
		
		public bool closeAfterUpload;	
		
		public RedmineDataBuffer() {
			projects = new Hashtable();
			priorities = new Hashtable();
			trackers = new Hashtable();
			issues = new Hashtable();
			trackers = new Hashtable();
			currentIssues = new Hashtable();
			defaultProject = 0;
			defaultTracker = 0;
			defaultPriority = 0;
			defaultStatus = 0;
			host = "";
			apikey = "";
			closeAfterUpload = true;
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
			} catch{
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
			return theReturn;
		}	

	}
	
}
