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
using System.Windows;
using System.Windows.Forms;
using System.Collections;
using Redmine.Net.Api;
using Redmine.Net.Api.Types;

namespace GreenshotRedmineUploader
{
	 
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
		
		RedmineSettings.CustomFieldDefinition[] customFieldDefinitions;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			customFieldDefinitions = Program.redmine.getCustomFieldDefinitions();
			customFieldsNew = new Control[customFieldDefinitions.Length];
			customFieldsUpdate = new Control[customFieldDefinitions.Length];
			for (int i = 0;i < customFieldDefinitions.Length; i++) {
				createCustomField( customFieldDefinitions[i], i );
			}
		}
		
		private Control[] customFieldsNew;
		private Control[] customFieldsUpdate;
		
		private const int customFieldHeight = 31;
		private const int customFieldStartPositionNewIssue = 270;
		private const int customFieldStartPositionUpdateIssue = 280;
		private int currentCustomFieldPositionNewIssue = customFieldStartPositionNewIssue;
		private int currentCustomFieldPositionUpdateIssue = customFieldStartPositionUpdateIssue;
		private void createCustomField(RedmineSettings.CustomFieldDefinition definition, int index) {
			//Window
			this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height + customFieldHeight);
			
			//New Issues
			this.issueDescription.Size = new System.Drawing.Size(this.issueDescription.Size.Width, this.issueDescription.Size.Height - customFieldHeight );
			Label newIssueLabel = new System.Windows.Forms.Label();
			newIssueLabel.AutoSize = true;
			newIssueLabel.Location = new System.Drawing.Point(8, currentCustomFieldPositionNewIssue);
			newIssueLabel.Size = new System.Drawing.Size(52, 13);
			newIssueLabel.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))));
			newIssueLabel.Text = string.Concat(definition.name, ":");
			this.tabPage1.Controls.Add(newIssueLabel);
			
			if (definition.fieldtype == RedmineSettings.CustomFieldDefinition.Fieldtype.FieldTypeList) {
				ComboBox newInputElement = new System.Windows.Forms.ComboBox();
				newInputElement.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
				newInputElement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
				newInputElement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
				newInputElement.FormattingEnabled = true;
				newInputElement.Location = new System.Drawing.Point(65, currentCustomFieldPositionNewIssue);
				newInputElement.Size = new System.Drawing.Size(479, 21);
				newInputElement.Items.AddRange(definition.values);
				
				if (!definition.defaultValue.Equals("")) {
					newInputElement.SelectedIndex = newInputElement.FindStringExact(definition.defaultValue);
				}
				
				this.tabPage1.Controls.Add(newInputElement);
				customFieldsNew[index] = newInputElement;
			} else {
				TextBox newInputElement = new System.Windows.Forms.TextBox();
				newInputElement.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
				newInputElement.Location = new System.Drawing.Point(65, currentCustomFieldPositionNewIssue);
				newInputElement.Size = new System.Drawing.Size(479, 20);
				
				newInputElement.Text = definition.defaultValue;
				this.tabPage1.Controls.Add(newInputElement);
				customFieldsNew[index] = newInputElement;
			}
			
			currentCustomFieldPositionNewIssue += customFieldHeight;
			
			
			//Update Issues
			this.issueNote.Size = new System.Drawing.Size(this.issueNote.Size.Width, this.issueNote.Size.Height - customFieldHeight );
			Label updateIssueLabel = new System.Windows.Forms.Label();
			updateIssueLabel.AutoSize = true;
			updateIssueLabel.Location = new System.Drawing.Point(8, currentCustomFieldPositionUpdateIssue);
			updateIssueLabel.Size = new System.Drawing.Size(52, 13);
			updateIssueLabel.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))));
			updateIssueLabel.Text = string.Concat(definition.name, ":");
			this.tabPage2.Controls.Add(updateIssueLabel);
			
			if (definition.fieldtype == RedmineSettings.CustomFieldDefinition.Fieldtype.FieldTypeList) {
				ComboBox updateInputElement = new System.Windows.Forms.ComboBox();
				updateInputElement.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
				updateInputElement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
				updateInputElement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
				updateInputElement.FormattingEnabled = true;
				updateInputElement.Location = new System.Drawing.Point(65, currentCustomFieldPositionUpdateIssue);
				updateInputElement.Size = new System.Drawing.Size(479, 21);
				updateInputElement.Items.AddRange(definition.values);
				this.tabPage2.Controls.Add(updateInputElement);
				customFieldsUpdate[index] = updateInputElement;
			} else {
				TextBox updateInputElement = new System.Windows.Forms.TextBox();
				updateInputElement.Anchor = 
					((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
				updateInputElement.Location = new System.Drawing.Point(65, currentCustomFieldPositionUpdateIssue);
				updateInputElement.Size = new System.Drawing.Size(479, 20);
				this.tabPage2.Controls.Add(updateInputElement);
				customFieldsUpdate[index] = updateInputElement;
			}
			
			currentCustomFieldPositionUpdateIssue += customFieldHeight;
			/*
			
			this.issueNote = new System.Windows.Forms.TextBox();
			// 
			// issueNote
			// 
			this.issueNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.issueNote.Location = new System.Drawing.Point(9, 238);
			this.issueNote.Multiline = true;
			this.issueNote.Name = "issueNote";
			this.issueNote.Size = new System.Drawing.Size(526, 65);
			this.issueNote.TabIndex = 15;
			this.tabPage2.Controls.Add(this.issueNote);
			;*/
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
			this.oldIssueTracker.DataSource = trackerListBS;		
			try { 			
				this.issueTracker.ValueMember = "Value";
	            this.issueTracker.DisplayMember = "Key";
	            this.issueTracker.SelectedValue = Program.redmine.buffer.defaultTracker;
	            
	            this.oldIssueTracker.ValueMember = "Value";
	            this.oldIssueTracker.DisplayMember = "Key";
	            this.oldIssueTracker.SelectedValue = Program.redmine.buffer.defaultTracker;
	        } catch (Exception) {
        		this.issueTracker.DataSource = null;
        		this.oldIssueTracker.DataSource = null;
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
			this.oldIssue.Tag = null;
			this.oldIssue.DataSource = allIssuesListBS;		
			try { 			
				this.oldIssue.ValueMember = "Value";
	            this.oldIssue.DisplayMember = "Key";
	            this.oldIssue.SelectedIndex = 0;
	            this.oldIssue.SelectedIndex = -1; //Lol @ http://support.microsoft.com/default.aspx?scid=kb;en-us;327244
  	        } catch (Exception e) {
				System.Console.Out.Write(e.Message);
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
        	string result = issueselection.Text;
        	try {
        		if (issueselection.SelectedValue != null && (int)issueselection.SelectedValue != 0 ) {
        			result = issueselection.SelectedValue.ToString();
        		}
        	} catch (Exception) {
        		
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
				this.oldissueAssignee.SelectedIndex = this.oldissueAssignee.FindStringExact(issue.AssignedTo != null ? issue.AssignedTo.Name : "No Change");
        	} catch (Exception) {
        		this.oldissueAssignee.DataSource = null;
        	}
        	
        	try {
        		this.issueCategoryListBS.DataSource = Program.redmine.getProjectCategoryList(issue.Project.Id.ToString());
        		this.oldIssueCategory.DataSource = issueCategoryListBS;        	
	        	this.oldIssueCategory.ValueMember = "Value";
	            this.oldIssueCategory.DisplayMember = "Key";	            
				this.oldIssueCategory.SelectedIndex = this.oldIssueCategory.FindStringExact(issue.Category != null ? issue.Category.Name : "No Change");
        	} catch (Exception) {
        		this.oldIssueCategory.DataSource = null;
        	}

        	try {
        		this.issueVersionListBS.DataSource = Program.redmine.getProjectVersionList(issue.Project.Id.ToString());
        		this.oldIssueVersion.DataSource = issueVersionListBS;        	
	        	this.oldIssueVersion.ValueMember = "Value";
	            this.oldIssueVersion.DisplayMember = "Key";
				this.oldIssueVersion.SelectedIndex = this.oldIssueVersion.FindStringExact(issue.FixedVersion != null ? issue.FixedVersion.Name : "No Change");
        	} catch (Exception) {
        		this.oldIssueVersion.DataSource = null;
        	}
        	
			this.oldissuePriority.SelectedIndex = this.oldissuePriority.FindStringExact(issue.Priority != null ? issue.Priority.Name : "No Change");
			this.oldissueStatus.SelectedIndex = this.oldissueStatus.FindStringExact(issue.Status != null ? issue.Status.Name : "No Change");
			this.oldIssueTracker.SelectedIndex = this.oldIssueTracker.FindStringExact(issue.Tracker != null ? issue.Tracker.Name : "No Change");
        	
			for (int i = 0;i < customFieldsUpdate.Length;i++) {
				for (int y = 0;y < issue.CustomFields.Count;y++) {
					if (issue.CustomFields[y].Id == customFieldDefinitions[i].id) {
						if (issue.CustomFields[y].Values.Count > 0) {
							customFieldsUpdate[i].Text = issue.CustomFields[y].Values[0].ToString();
						} else {
							customFieldsUpdate[i].Text = "";
						} 
						break;
					}
				}
			}
			
            this.Enabled = true;
        }
        
        private void syncSave_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
        	Program.redmine.syncIssueList();        	
        	connectDataSourcesIssueLists();
        	if (!Program.redmine.buffer.Save()) {
        		System.Windows.Forms.MessageBox.Show("Error while saving - data wasn't saved.","Error");
        	} else {
        		System.Windows.Forms.MessageBox.Show("Settings saved.","Success");
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
        		
        		for (int i = 0;i < customFieldsNew.Length;i++) {
        			CustomField item = new CustomField();
        			item.Id = customFieldDefinitions[i].id;
        			item.Multiple = false;
        			item.Name = customFieldDefinitions[i].name;
        			
        			CustomFieldValue customFieldValue = new CustomFieldValue();
        			customFieldValue.Info = customFieldsNew[i].Text;
        			item.Values = new List<CustomFieldValue>();
        			item.Values.Add(customFieldValue);
        			newIssue.CustomFields = new List<CustomField>();
        			newIssue.CustomFields.Add(item);
				}
        		
        		newIssue = Program.redmine.createIssue(newIssue); 

				DialogResult messageBoxResult = 
					MessageBox.Show(
						String.Concat("Issue #",newIssue.Id," succesfully created.\nOpen Issue now?"), 
						"Success!", 
						MessageBoxButtons.YesNo
					);
				if (messageBoxResult.ToString() == "Yes") {
					String uri = new UriBuilder(Program.redmine.buffer.host).Uri.ToString();
					System.Diagnostics.Process.Start(String.Concat(uri ,"issues/",newIssue.Id));
				}    
				
				if (Program.redmine.buffer.closeAfterUpload) {
					Application.Exit();
				}
				
        	} catch (Exception ex) {
        		System.Windows.Forms.MessageBox.Show(ex.Message,"Error while creating issue.");
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
        		if (oldIssueTracker.SelectedValue != null && (int)oldIssueTracker.SelectedValue != 0) {
        			updateIssue.Tracker = new IdentifiableName{Id = (int)oldIssueTracker.SelectedValue};	
        		}
        		
        		if (updateIssue.CustomFields == null) {
        			updateIssue.CustomFields = new List<CustomField>();
        		}
        		
        		for (int i = 0;i < customFieldsUpdate.Length;i++) {
        			CustomField item = new CustomField();
        			item.Id = customFieldDefinitions[i].id;
        			item.Multiple = false;
        			item.Name = customFieldDefinitions[i].name;
        			
        			for (int y = 0;y < updateIssue.CustomFields.Count;y++) {
        				if (updateIssue.CustomFields[y].Id == item.Id) {
        					updateIssue.CustomFields.Remove(updateIssue.CustomFields[y]);
        					break;
        				}
        			}
        			
        			CustomFieldValue customFieldValue = new CustomFieldValue();
        			customFieldValue.Info = customFieldsUpdate[i].Text;
        			item.Values = new List<CustomFieldValue>();
        			item.Values.Add(customFieldValue);
        			updateIssue.CustomFields.Add(item);
				}

        		Program.redmine.updateIssue(updateIssue); 
				
				DialogResult messageBoxResult = 
					MessageBox.Show(
						String.Concat("Issue #",updateIssue.Id," succesfully updated.\nOpen Issue now?"), 
						"Success!", 
						MessageBoxButtons.YesNo
					);
				if (messageBoxResult.ToString() == "Yes") {
					String uri = new UriBuilder(Program.redmine.buffer.host).Uri.ToString();
					System.Diagnostics.Process.Start(String.Concat(uri ,"issues/",updateIssue.Id));
				}
				
				if (Program.redmine.buffer.closeAfterUpload) {
					Application.Exit();
				}
				
        	} catch (Exception ex) {
        		System.Windows.Forms.MessageBox.Show(ex.Message,"Error while updating issue.");
        	}
        	this.Enabled = true;
        }     
		
		
		void OldIssueKeyPress(object sender, KeyPressEventArgs e)
		{	
			this.OldIssuePressed(true,e.KeyChar);				
		}
		
		void OldIssueTextChanged(object sender, EventArgs e)
		{
			if (this.oldIssue.Text.Length == 0) this.OldIssuePressed(false,'\0');			
			
		}
		
		object locker = new object();
		void OldIssuePressed(bool pressed,char key) {
			lock (locker) {				
				if (pressed) {
					this.oldIssue.DroppedDown = true;
				}
				
				string original = this.oldIssue.Text;
				int originalCursorSelectionStart = this.oldIssue.SelectionStart;
				int originalCursorSelectionLength = this.oldIssue.SelectionLength;				
				
				
				string s = this.oldIssue.Text.ToLower();
				if (originalCursorSelectionStart >= 0 && originalCursorSelectionStart < s.Length) {
					s.Remove(originalCursorSelectionStart);	
				}
				
				if (char.IsControl(key)) {
					if (key == '\x08' /*backspace*/) {
						if (originalCursorSelectionStart-1 >= 0 && originalCursorSelectionStart-1 < s.Length) {
							s.Remove(originalCursorSelectionStart-1);	
						}	
					}
				} else {
					s = String.Concat(s,key ).ToLower();	
				}
				

				SortedDictionary<string,int> filteredIssue;						    
				if (s.Length > 0) {
					filteredIssue = new SortedDictionary<string,int>();
					foreach (KeyValuePair<string,int> item in Program.redmine.buffer.allIssues) {
						if (item.Key.ToString().ToLower().Contains(s)) {
							filteredIssue.Add(item.Key,item.Value);
						}
					}
				} else {
				 filteredIssue = Program.redmine.buffer.allIssues;	
				}
				allIssuesListBS.DataSource = filteredIssue;         	
			    this.oldIssue.DataSource = allIssuesListBS;	
			    	    			    
			    this.oldIssue.Text = original;
			    this.oldIssue.Select(originalCursorSelectionStart,originalCursorSelectionLength);			    			    		
			}
		}
	}
	
	
	 public class FontType
    {
        
        public String Name;
        public String DisplayName;
    }
}
