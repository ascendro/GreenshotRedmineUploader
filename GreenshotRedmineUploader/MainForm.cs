/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 2:27 
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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;

namespace GreenshotRedmineUploader
{
	 public class FontType
    {
        
        public String Name;
        public String DisplayName;
    }
	 
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		BindingSource projectListBS = new BindingSource();
		BindingSource trackerListBS = new BindingSource();
		BindingSource priorityListBS = new BindingSource();
		BindingSource statusesListBS = new BindingSource();
		BindingSource projectAssigneeListBS = new BindingSource();
		BindingSource projectCategoryListBS = new BindingSource();
		BindingSource projectVersionListBS = new BindingSource();
		BindingSource issueAssigneeListBS = new BindingSource();
		BindingSource issueCategoryListBS = new BindingSource();
		BindingSource issueVersionListBS = new BindingSource();
		BindingSource allIssuesListBS = new BindingSource();
		BindingSource currentIssuesListBS = new BindingSource();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
		}
		
		public void setFilesource(string filesource) {
			this.filesource.Text = filesource;
			this.filename.Text = System.IO.Path.GetFileName(filesource);
		}
		
		private void MainForm_Load(object sender, EventArgs e)
        {
			connectDataSources();
        }
		
        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = filesource.Text;
            openFileDialog1.ShowDialog();
            filesource.Text = openFileDialog1.FileName;
            filename.Text = openFileDialog1.SafeFileName;
        }
        
        private void settings_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Form settings = new SettingsForm();
            settings.Show();
            connectDataSources();
        }
        
        public void reconnectData() {
        	this.Enabled = false;
        	connectDataSources();
        	this.Enabled = true;
        }
        
        private void connectDataSources() {
        	projectListBS.DataSource = typeof(List<int>);
            projectListBS.DataSource = Program.redmine.buffer.projects;
			this.projectList.DataSource = projectListBS;
			try { 			
				this.projectList.ValueMember = "Value";
	            this.projectList.DisplayMember = "Key";
	            this.projectList.SelectedValue = Program.redmine.buffer.defaultProject;
	        } catch (Exception) {
        		this.projectList.DataSource = null;
        	}
            
			trackerListBS.DataSource = typeof(List<int>);
            trackerListBS.DataSource = Program.redmine.buffer.trackers;
			this.issueTracker.DataSource = trackerListBS;		
			try { 			
				this.issueTracker.ValueMember = "Value";
	            this.issueTracker.DisplayMember = "Key";
	            this.issueTracker.SelectedValue = Program.redmine.buffer.defaultTracker;
	        } catch (Exception) {
        		this.issueTracker.DataSource = null;
        	}

			priorityListBS.DataSource = typeof(List<int>);
            priorityListBS.DataSource = Program.redmine.buffer.priorities;
			this.issuePriority.DataSource = priorityListBS;		
			try { 			
				this.issuePriority.ValueMember = "Value";
	            this.issuePriority.DisplayMember = "Key";          
	            this.issuePriority.SelectedValue = Program.redmine.buffer.defaultPriority;				
	        } catch (Exception) {
        		this.issuePriority.DataSource = null;
        	}
			
			this.oldissuePriority.DataSource = priorityListBS;	
			try { 			
				this.oldissuePriority.ValueMember = "Value";
	            this.oldissuePriority.DisplayMember = "Key";
	            this.oldissuePriority.SelectedValue = Program.redmine.buffer.defaultPriority;
  	        } catch (Exception) {
        		this.oldissuePriority.DataSource = null;
        	}
          
			statusesListBS.DataSource = typeof(List<int>);
            statusesListBS.DataSource = Program.redmine.buffer.statuses;
			this.oldissueStatus.DataSource = statusesListBS;		
			try { 			
				this.oldissueStatus.ValueMember = "Value";
	            this.oldissueStatus.DisplayMember = "Key";
	            this.oldissueStatus.SelectedValue = Program.redmine.buffer.defaultStatus;
  	        } catch (Exception) {
        		this.oldissueStatus.DataSource = null;
        	}
          
            this.issueSubject.Text = Program.redmine.buffer.defaultSubject;
            
            connectDataSourcesIssueLists();
        }  
        
        private void connectDataSourcesIssueLists() {
        	if (projectList.SelectedValue != null) {
        		Program.redmine.getCurrentList((int)projectList.SelectedValue);
        	}
        	
        	allIssuesListBS.DataSource = typeof(List<int>);
        	allIssuesListBS.DataSource = Program.redmine.buffer.allIssues;
			this.oldIssue.DataSource = allIssuesListBS;		
			try { 			
				this.oldIssue.ValueMember = "Value";
	            this.oldIssue.DisplayMember = "Key";
	            this.oldIssue.SelectedIndex = 0;
	            this.oldIssue.SelectedIndex = -1; //Lol @ http://support.microsoft.com/default.aspx?scid=kb;en-us;327244
  	        } catch (Exception) {
        		this.oldIssue.DataSource = null;
        	}
			
			currentIssuesListBS.DataSource = typeof(List<int>);
			currentIssuesListBS.DataSource = Program.redmine.buffer.currentIssues;
			this.parentIssue.DataSource = currentIssuesListBS;		
			try { 			
				this.parentIssue.ValueMember = "Value";
	            this.parentIssue.DisplayMember = "Key";
	            this.parentIssue.SelectedIndex = 0;
	            this.parentIssue.SelectedIndex = -1; //Lol @ http://support.microsoft.com/default.aspx?scid=kb;en-us;327244
  	        } catch (Exception) {
        		this.parentIssue.DataSource = null;
        	}
        }
        
        private bool SelectedIndexChangedEventLoop = false;
        public  void projectList_SelectedIndexChanged(object sender, System.EventArgs e) {
        	if (!SelectedIndexChangedEventLoop) {
        		SelectedIndexChangedEventLoop = true;
        		connectDataSourcesIssueLists();
        	}
        	SelectedIndexChangedEventLoop = false;
        }
        
        private string getSelectedIssueId(ComboBox issueselection) {
        	string result;
        	if (issueselection.SelectedValue != null && (int)issueselection.SelectedValue != 0 ) {
        		result = issueselection.SelectedValue.ToString();
        	} else {
        		result = issueselection.Text;
        	}
        	return result;
        }
        
        private void issueAssigneeListUpdate_Click(object sender, EventArgs e)
        {
        	
        	this.Enabled = false;
        	Issue issue = Program.redmine.getPlainIssue(this.getSelectedIssueId(this.oldIssue));
        	
        	if (issue == null) {
        		this.Enabled = true;
        		return;
        	} 
        	
        	try {
        		this.issueAssigneeListBS.DataSource = Program.redmine.getProjectAssigneeList(issue.Project.Id.ToString());
        		this.oldissueAssignee.DataSource = issueAssigneeListBS;        	
	        	this.oldissueAssignee.ValueMember = "Value";
	            this.oldissueAssignee.DisplayMember = "Key";	            
	            this.oldissueAssignee.SelectedIndex = this.oldissueAssignee.FindStringExact(issue.AssignedTo.Name);
        	} catch (Exception) {
        		this.oldissueAssignee.DataSource = null;
        	}
        	
        	try {
        		this.issueCategoryListBS.DataSource = Program.redmine.getProjectCategoryList(issue.Project.Id.ToString());
        		this.oldIssueCategory.DataSource = issueCategoryListBS;        	
	        	this.oldIssueCategory.ValueMember = "Value";
	            this.oldIssueCategory.DisplayMember = "Key";	            
	            this.oldIssueCategory.SelectedIndex = this.oldIssueCategory.FindStringExact(issue.Category.Name);
        	} catch (Exception) {
        		this.oldIssueCategory.DataSource = null;
        	}

        	try {
        		this.issueVersionListBS.DataSource = Program.redmine.getProjectVersionList(issue.Project.Id.ToString());
        		this.oldIssueVersion.DataSource = issueVersionListBS;        	
	        	this.oldIssueVersion.ValueMember = "Value";
	            this.oldIssueVersion.DisplayMember = "Key";	            
	            this.oldIssueVersion.SelectedIndex = this.oldIssueVersion.FindStringExact(issue.FixedVersion.Name);
        	} catch (Exception) {
        		this.oldIssueVersion.DataSource = null;
        	}
        	
        	this.oldissuePriority.SelectedIndex = this.oldissuePriority.FindStringExact(issue.Priority.Name);
        	this.oldissueStatus.SelectedIndex = this.oldissueStatus.FindStringExact(issue.Status.Name);
        	
            this.Enabled = true;
        }
        
        private void syncSave_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
        	Program.redmine.syncIssueList();        	
        	connectDataSourcesIssueLists();
        	if (!Program.redmine.buffer.Save()) {
        		MessageBox.Show("Error while saving - data wasn't saved.","Error");
        	} else {
        		MessageBox.Show("Settings saved.","Success");
        	}
        	this.Enabled = true;
        }
        
        private void projectAssigneeListUpdate_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
			try {        	
        		this.projectAssigneeListBS.DataSource = Program.redmine.getProjectAssigneeList(this.projectList.SelectedValue.ToString());
	        	this.issueAssignee.DataSource = projectAssigneeListBS;	        	
	        	this.issueAssignee.ValueMember = "Value";
	            this.issueAssignee.DisplayMember = "Key";
	            this.issueAssignee.SelectedIndex = this.issueAssignee.FindStringExact("No Change");
        	} catch (Exception) {
        		this.issueAssignee.DataSource = null;
        	}
            this.Enabled = true;
        }     

		void ProjectCategoryListUpdateClick(object sender, EventArgs e)
		{
        	this.Enabled = false;
			try {        	
        		this.projectCategoryListBS.DataSource = Program.redmine.getProjectCategoryList(this.projectList.SelectedValue.ToString());						
	        	this.issueCategory.DataSource = projectCategoryListBS;	        	
	        	this.issueCategory.ValueMember = "Value";
	            this.issueCategory.DisplayMember = "Key";
	            this.issueCategory.SelectedIndex = this.issueCategory.FindStringExact("No Change");
        	} catch (Exception) {
        		this.issueCategory.DataSource = null;
        	}
            this.Enabled = true;
		}
		
		void ProjectVersionListUpdateClick(object sender, EventArgs e)
		{
        	this.Enabled = false;
			try {        	
        		this.projectVersionListBS.DataSource = Program.redmine.getProjectVersionList(this.projectList.SelectedValue.ToString());
	        	this.issueVersion.DataSource = projectVersionListBS;	        	
	        	this.issueVersion.ValueMember = "Value";
	            this.issueVersion.DisplayMember = "Key";
	            this.issueVersion.SelectedIndex = this.issueVersion.FindStringExact("No Change");
        	} catch (Exception) {
        		this.issueVersion.DataSource = null;
        	}
            this.Enabled = true;	
		}
		
		void ProjectAllListUpdateClick(object sender, EventArgs e)
		{
			this.ProjectVersionListUpdateClick(sender,e); 
			this.ProjectCategoryListUpdateClick(sender,e); 
			this.projectAssigneeListUpdate_Click(sender,e);
		}        
        
        private void newIssue(object sender, EventArgs e) {
        	this.Enabled = false;
        	try {
        		var upload = Program.redmine.uploadFile(this.filesource.Text);

        		//Create a issue.
        		if (issueTracker.SelectedValue == null ||
        		    upload == null ||
        		    projectList.SelectedValue == null) {
        			throw new Exception("Tracker, Upload and Project needs to be set!");
        		}
        		
        		upload.FileName = this.filename.Text;
        		upload.ContentType = "application/octet-stream";
        		upload.Description = this.description.Text;
        		IList<Upload> uploads = new List<Upload>();
        		uploads.Add(upload);
        		
        		
            	var newIssue = new Issue { Subject = this.issueSubject.Text,         						
        									Project = new IdentifiableName{Id =  (int)projectList.SelectedValue},
        									Tracker = new IdentifiableName{Id =  (int)issueTracker.SelectedValue},        									
        									Description = this.issueDescription.Text,        									
        									Uploads = uploads
        								};
        		
        		string parentIssue = this.getSelectedIssueId(this.parentIssue);
        		if (parentIssue != "") {
        			newIssue.ParentIssue = new IdentifiableName{Id = int.Parse(parentIssue)};
        		}
        		if (issuePriority.SelectedValue != null && (int)issuePriority.SelectedValue != 0 ) {
        			newIssue.Priority = new IdentifiableName{Id = (int)issuePriority.SelectedValue};	
        		}
        		if (issueAssignee.SelectedValue != null && (int)issueAssignee.SelectedValue != 0 ) {
        			newIssue.AssignedTo = new IdentifiableName{Id = (int)issueAssignee.SelectedValue};
        		}
        		if (issueCategory.SelectedValue != null && (int)issueCategory.SelectedValue != 0) {
        			newIssue.Category = new IdentifiableName{Id = (int)issueCategory.SelectedValue};	
        		}
        		if (issueVersion.SelectedValue != null && (int)issueVersion.SelectedValue != 0) {
        			newIssue.FixedVersion = new IdentifiableName{Id = (int)issueVersion.SelectedValue};
        		}
        		newIssue = Program.redmine.createIssue(newIssue);        	
				MessageBox.Show(String.Concat("Issue #",newIssue.Id," succesfully created"),"Success!");
				
				if (Program.redmine.buffer.closeAfterUpload) {
					Application.Exit();
				}
				
        	} catch (Exception ex) {
        		MessageBox.Show(ex.Message,"Error while creating issue.");
        	}
        	this.Enabled = true;
        }
        
        private void updateIssue(object sender, EventArgs e) {
        	this.Enabled = false;
        	try {
        		var upload = Program.redmine.uploadFile(this.filesource.Text);

        		if (upload == null) {
        			throw new Exception("Tracker, Upload and Project needs to be set!");
        		}
        		
        		upload.FileName = this.filename.Text;
        		upload.ContentType = "application/octet-stream";
        		upload.Description = this.description.Text;
        		   	
        		var updateIssue = Program.redmine.getIssue(this.getSelectedIssueId(this.oldIssue));
        		
        		if (updateIssue.Uploads == null) {
        			updateIssue.Uploads = new List<Upload>();
        		} 
        		updateIssue.Uploads.Add(upload);
        		if (this.issueNote.Text.Length > 0) {
        			updateIssue.Notes = this.issueNote.Text;
        		}
        		

        		if (oldissuePriority.SelectedValue != null && (int)oldissuePriority.SelectedValue != 0 ) {
        			updateIssue.Priority = new IdentifiableName{Id = (int)oldissuePriority.SelectedValue};	
        		}
        		if (oldissueAssignee.SelectedValue != null && (int)oldissueAssignee.SelectedValue != 0 ) {
        			updateIssue.AssignedTo = new IdentifiableName{Id = (int)oldissueAssignee.SelectedValue};
        		}
        		if (oldissueStatus.SelectedValue != null && (int)oldissueStatus.SelectedValue != 0 ) {
        			updateIssue.Status = new IdentifiableName{Id = (int)oldissueStatus.SelectedValue};
        		}
        		if (oldIssueCategory.SelectedValue != null && (int)oldIssueCategory.SelectedValue != 0) {
        			updateIssue.Category = new IdentifiableName{Id = (int)oldIssueCategory.SelectedValue};	
        		}
        		if (oldIssueVersion.SelectedValue != null && (int)oldIssueVersion.SelectedValue != 0) {
        			updateIssue.FixedVersion = new IdentifiableName{Id = (int)oldIssueVersion.SelectedValue};	
        		}

        		Program.redmine.updateIssue(updateIssue); 
        		        		
				MessageBox.Show(String.Concat("Issue #",updateIssue.Id," succesfully updated"),"Success!");
				
				if (Program.redmine.buffer.closeAfterUpload) {
					Application.Exit();
				}
				
        	} catch (Exception ex) {
        		MessageBox.Show(ex.Message,"Error while updating issue.");
        	}
        	this.Enabled = true;
        }     
		
	}
}
