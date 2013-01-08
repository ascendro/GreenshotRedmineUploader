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
		BindingSource issueAssigneeListBS = new BindingSource();
		
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
            projectListBS.DataSource = Program.redmine.buffer.projects;
			this.projectList.DataSource = projectListBS;
			try { 			
				this.projectList.ValueMember = "Value";
	            this.projectList.DisplayMember = "Key";
	            this.projectList.SelectedValue = Program.redmine.buffer.defaultProject;
	        } catch (Exception) {
        		this.projectList.DataSource = null;
        	}
            
            trackerListBS.DataSource = Program.redmine.buffer.trackers;
			this.issueTracker.DataSource = trackerListBS;		
			try { 			
				this.issueTracker.ValueMember = "Value";
	            this.issueTracker.DisplayMember = "Key";
	            this.issueTracker.SelectedValue = Program.redmine.buffer.defaultTracker;
	        } catch (Exception) {
        		this.issueTracker.DataSource = null;
        	}

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
              	
        }  
        
        private void issueAssigneeListUpdate_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
        	try {
        		this.issueAssigneeListBS.DataSource = Program.redmine.getIssueAssigneeList(this.oldissueID.Text);        	
        		this.oldissueAssignee.DataSource = issueAssigneeListBS;        	
	        	this.oldissueAssignee.ValueMember = "Value";
	            this.oldissueAssignee.DisplayMember = "Key";
        	} catch (Exception) {
        		this.oldissueAssignee.DataSource = null;
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
        	} catch (Exception) {
        		this.issueAssignee.DataSource = null;
        	}
            this.Enabled = true;
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
        		if (issuePriority.SelectedValue != null && (int)issuePriority.SelectedValue != 0 ) {
        			newIssue.Priority = new IdentifiableName{Id = (int)issuePriority.SelectedValue};	
        		}
        		if (issueAssignee.SelectedValue != null && (int)issueAssignee.SelectedValue != 0 ) {
        			newIssue.AssignedTo = new IdentifiableName{Id = (int)issueAssignee.SelectedValue};
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
        		   	
        		var updateIssue = Program.redmine.getIssue(this.oldissueID.Text);
        		
        		if (updateIssue.Uploads == null) {
        			updateIssue.Uploads = new List<Upload>();
        		} 
        		updateIssue.Uploads.Add(upload);
        		if (this.issueNote.Text.Length > 0) {
        			updateIssue.UpdateNote = this.issueNote.Text;
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
