/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 3:26 
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
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace GreenshotRedmineUploader
{
	/// <summary>
	/// Description of SettingsForm.
	/// </summary>
	public partial class SettingsForm : Form
	{
		BindingSource projectListBS = new BindingSource();
		BindingSource trackerListBS = new BindingSource();
		BindingSource priorityListBS = new BindingSource();
		BindingSource statusesListBS = new BindingSource();
		
		bool syncedWithRedmine = false;
		
		public SettingsForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		
        private void settings_Load(object sender, EventArgs e)
        {
        	syncedWithRedmine = false;
        	this.Enabled = false;
        	connectDataSources();
        	this.Enabled = true;
        }
        
        private void connectDataSources() {
        	this.redmineAPIKey.Text = Program.redmine.buffer.apikey;
			this.redmineHost.Text = Program.redmine.buffer.host;
			
			projectListBS.DataSource = typeof(List<int>);			
            projectListBS.DataSource = Program.redmine.buffer.projects;            
			this.redmineDefaultProject.DataSource = projectListBS;	
			try {			
				this.redmineDefaultProject.ValueMember = "Value";
	            this.redmineDefaultProject.DisplayMember = "Key";
	            this.redmineDefaultProject.SelectedValue = Program.redmine.buffer.defaultProject;
            } catch (Exception) {
        		this.redmineDefaultProject.DataSource = null;
        	}
		
            
			trackerListBS.DataSource = typeof(List<int>);
            trackerListBS.DataSource = Program.redmine.buffer.trackers;
			this.redmineDefaultTracker.DataSource = trackerListBS;	
			try {			
				this.redmineDefaultTracker.ValueMember = "Value";
	            this.redmineDefaultTracker.DisplayMember = "Key";
	            this.redmineDefaultTracker.SelectedValue = Program.redmine.buffer.defaultTracker;
            } catch (Exception) {
        		this.redmineDefaultTracker.DataSource = null;
        	}

			priorityListBS.DataSource = typeof(List<int>);	
            priorityListBS.DataSource = Program.redmine.buffer.priorities;
            this.redmineDefaultPriority.DataSource = priorityListBS;
			try {						
	            this.redmineDefaultPriority.ValueMember = "Value";
	            this.redmineDefaultPriority.DisplayMember = "Key";          
	            this.redmineDefaultPriority.SelectedValue = Program.redmine.buffer.defaultPriority;
            } catch (Exception) {
        		this.redmineDefaultPriority.DataSource = null;
        	}
            
            statusesListBS.DataSource = typeof(List<int>);	
            statusesListBS.DataSource = Program.redmine.buffer.statuses;
			this.redmineDefaultStatus.DataSource = statusesListBS;		
			try {
				this.redmineDefaultStatus.ValueMember = "Value";
	            this.redmineDefaultStatus.DisplayMember = "Key";
	            this.redmineDefaultStatus.SelectedValue = Program.redmine.buffer.defaultStatus;
            } catch (Exception) {
        		this.redmineDefaultStatus.DataSource = null;
        	}
            
            this.redmineDefaultSubject.Text = Program.redmine.buffer.defaultSubject;
            
            this.redmineCloseAfterUpload.Checked = Program.redmine.buffer.closeAfterUpload;
            
            this.redmineOnlyImportOpenVersions.Checked = Program.redmine.buffer.onlyImportOpenVersions;
            
            this.disableSSLVerification.Checked = Program.redmine.buffer.disableSSLVerification;
            
            this.txtCustomFields.Text = Program.redmine.buffer.customFields;
            
        }  
        
        private void storeData() {
        	Program.redmine.buffer.apikey = this.redmineAPIKey.Text;
        	Program.redmine.buffer.host = this.redmineHost.Text;
        	Program.redmine.resetConnection();
			        	
        	if (this.redmineDefaultProject.SelectedValue != null) {
        		Program.redmine.buffer.defaultProject = (int)this.redmineDefaultProject.SelectedValue;
        	} else {
        		Program.redmine.buffer.defaultProject = 0;
        	}
        	if (this.redmineDefaultTracker.SelectedValue != null) {
        		Program.redmine.buffer.defaultTracker = (int)this.redmineDefaultTracker.SelectedValue;
        	} else {
        		Program.redmine.buffer.defaultTracker = 0;
        	}
        	if (this.redmineDefaultPriority.SelectedValue != null) {
        		Program.redmine.buffer.defaultPriority = (int)this.redmineDefaultPriority.SelectedValue;
        	} else {
        		Program.redmine.buffer.defaultPriority = 0;
        	}
        	if (this.redmineDefaultStatus.SelectedValue != null) {
        		Program.redmine.buffer.defaultStatus = (int)this.redmineDefaultStatus.SelectedValue;
        	} else {
        		Program.redmine.buffer.defaultStatus = 0;
        	}
            
            Program.redmine.buffer.defaultSubject = this.redmineDefaultSubject.Text;
            
            Program.redmine.buffer.closeAfterUpload = this.redmineCloseAfterUpload.Checked;
            Program.redmine.buffer.onlyImportOpenVersions = this.redmineOnlyImportOpenVersions.Checked;
            Program.redmine.buffer.disableSSLVerification = this.disableSSLVerification.Checked;
            
            Program.redmine.buffer.customFields = this.txtCustomFields.Text;
        }

        private void redmineSync_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
        	storeData();
        	if (Program.redmine.syncWithRed()) {
        		connectDataSources();
        		MessageBox.Show("Succesfully synced with Redmine!","Success!");
        	} else {
        		connectDataSources();
        		MessageBox.Show("Error while syncing with Redmine!","Error");
        	}        	
        	syncedWithRedmine = true;
        	this.Enabled = true;
        }

        private void settingsSave_Click(object sender, EventArgs e)
        {        	
        	this.Enabled = false;
        	storeData();
        	if (!Program.redmine.buffer.Save()) {
        		MessageBox.Show("Error while saving - data wasn't saved.","Error");
        	} else {
        		MessageBox.Show("Settings saved.","Success");
        	}
        	this.Enabled = true;
 			this.Close();
        }

        private void settingsDiscard_Click(object sender, EventArgs e)
        {
        	this.Enabled = false;
        	//Discarding but we already changed things, so reread the settings from the file
        	if (syncedWithRedmine) {
        		Program.redmine.buffer = RedmineDataBuffer.Read();
        		if (Program.redmine.buffer == null) {
        			Program.redmine.buffer = new RedmineDataBuffer();
        		}
        	}
        	this.Enabled = true;
 			this.Close();
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {
        	Program.mainForm.reconnectData();
        }
		void Label9Click(object sender, EventArgs e)
		{
	
		}            
	}
}
