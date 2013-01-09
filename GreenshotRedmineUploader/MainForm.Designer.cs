using System.Windows.Forms;
/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 2:27 
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GreenshotRedmineUploader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "Ascendro S.R.L - GreenshotRedmineUploader";
			this.Name = "MainForm";
			
            this.projectList = new System.Windows.Forms.ComboBox();
            this.settings = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelOldIssue = new System.Windows.Forms.Label();
            this.labelOldIssueIdSign = new System.Windows.Forms.Label();
            this.labelFilename = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.labelFile = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filesource = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.btnNewIssueStart = new System.Windows.Forms.Button();
            this.issuePriority = new System.Windows.Forms.ComboBox();
            this.issueAssignee = new System.Windows.Forms.ComboBox();
            this.issueTracker = new System.Windows.Forms.ComboBox();
            this.issueDescription = new System.Windows.Forms.TextBox();
            this.issueNote = new System.Windows.Forms.TextBox();
            this.issueSubject = new System.Windows.Forms.TextBox();
            this.labelIssueDescription = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelAssignee = new System.Windows.Forms.Label();
            this.labelTracker = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelOldIssuePriority = new System.Windows.Forms.Label();
            this.labelOldIssueAssignee = new System.Windows.Forms.Label();
            this.labelOldIssueStatus = new System.Windows.Forms.Label();
            this.labelNoteDesc = new System.Windows.Forms.Label();
            this.oldissueUpload = new System.Windows.Forms.Button();
            this.oldissuePriority = new System.Windows.Forms.ComboBox();
            this.oldissueAssignee = new System.Windows.Forms.ComboBox();
            this.oldissueStatus = new System.Windows.Forms.ComboBox();
            
            this.projectAssigneeListUpdate = new System.Windows.Forms.Button();
        	this.issueAssigneeListUpdate = new System.Windows.Forms.Button();
            
        	this.labelParent = new System.Windows.Forms.Label();
	        this.newIssueSync = new System.Windows.Forms.Button();
	        this.oldIssueSync = new System.Windows.Forms.Button();
	        this.parentIssue = new System.Windows.Forms.ComboBox();
	        this.oldIssue = new System.Windows.Forms.ComboBox();
        	
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            
            
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(848, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 30;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(12, 44);
            this.labelFile.Name = "label10";
            this.labelFile.Size = new System.Drawing.Size(26, 13);	
            this.labelFile.Text = "File:";
            // 
            // filesource
            // 
            this.filesource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filesource.Location = new System.Drawing.Point(74, 41);
            this.filesource.Name = "filesource";
            this.filesource.Size = new System.Drawing.Size(768, 20);
            this.filesource.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFile
            // 
            this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFile.Location = new System.Drawing.Point(848, 41);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 14;
            this.openFile.Text = "Open";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(12, 70);
            this.labelFilename.Name = "label4";
            this.labelFilename.Size = new System.Drawing.Size(52, 13);
            this.labelFilename.Text = "Filename:";
            // 
            // filename
            // 
            this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filename.Location = new System.Drawing.Point(74, 67);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(852, 20);
            this.filename.TabIndex = 10;
			// 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(12, 100);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(52, 13);
            this.labelDesc.Text = "Description:";
            // 
            // description
            // 
            this.description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.description.Location = new System.Drawing.Point(74, 97);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(852, 20);
            this.description.TabIndex = 11;    
            
            
            //TAB PAGE 1 ###################################################################################################
            
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(8, 9);
            this.labelProject.Name = "label1";
            this.labelProject.Size = new System.Drawing.Size(43, 13);
            this.labelProject.Text = "Project:";
            // 
            // projectList
            // 
            this.projectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectList.FormattingEnabled = true;
            this.projectList.Location = new System.Drawing.Point(65, 6);
            this.projectList.Name = "projectList";
            this.projectList.Size = new System.Drawing.Size(760, 21);
            this.projectList.TabIndex = 1;
            this.projectList.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.projectList.AutoCompleteSource = AutoCompleteSource.ListItems;   
			this.projectList.SelectedIndexChanged += new System.EventHandler(projectList_SelectedIndexChanged);            
            // 
            // projectAssigneeListUpdate
            // 
            this.projectAssigneeListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectAssigneeListUpdate.Location = new System.Drawing.Point(825, 4);
            this.projectAssigneeListUpdate.Name = "projectAssigneeListUpdate";
            this.projectAssigneeListUpdate.Size = new System.Drawing.Size(75, 23);
            this.projectAssigneeListUpdate.Text = "Get Userlist";
            this.projectAssigneeListUpdate.UseVisualStyleBackColor = true;   
			this.projectAssigneeListUpdate.TabIndex = 2;            
            this.projectAssigneeListUpdate.Click += new System.EventHandler(this.projectAssigneeListUpdate_Click);
            
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(8, 40);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(46, 13);
            this.labelSubject.Text = "Subject:";
            // 
            // issueSubject
            // 
            this.issueSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueSubject.Location = new System.Drawing.Point(65, 37);
            this.issueSubject.Name = "issueSubject";
            this.issueSubject.Size = new System.Drawing.Size(830, 20);
            this.issueSubject.TabIndex = 3;
            // 
            // labelTracker
            // 
            this.labelTracker.AutoSize = true;
            this.labelTracker.Location = new System.Drawing.Point(6, 65);
            this.labelTracker.Name = "labelTracker";
            this.labelTracker.Size = new System.Drawing.Size(47, 13);
            this.labelTracker.Text = "Tracker:";
            // 
            // issueTracker
            // 
            this.issueTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueTracker.FormattingEnabled = true;
            this.issueTracker.Location = new System.Drawing.Point(65, 63);
            this.issueTracker.Name = "issueTracker";
            this.issueTracker.Size = new System.Drawing.Size(830, 21);
            this.issueTracker.TabIndex = 4;
            this.issueTracker.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.issueTracker.AutoCompleteSource = AutoCompleteSource.ListItems;    
            
            // 
            // labelAssignee
            // 
            this.labelAssignee.AutoSize = true;
            this.labelAssignee.Location = new System.Drawing.Point(6, 90);
            this.labelAssignee.Name = "label7";
            this.labelAssignee.Size = new System.Drawing.Size(53, 13);
            this.labelAssignee.Text = "Assignee:";
            // 
            // issueAssignee
            // 
            this.issueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueAssignee.FormattingEnabled = true;
            this.issueAssignee.Location = new System.Drawing.Point(65, 87);
            this.issueAssignee.Name = "issueAssignee";
            this.issueAssignee.Size = new System.Drawing.Size(830, 21);
            this.issueAssignee.TabIndex = 5;
            this.issueAssignee.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.issueAssignee.AutoCompleteSource = AutoCompleteSource.ListItems;    
            
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(8, 117);
            this.labelPriority.Name = "label8";
            this.labelPriority.Size = new System.Drawing.Size(41, 13);
            this.labelPriority.Text = "Priority:";
            // 
            // issuePriority
            // 
            this.issuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issuePriority.FormattingEnabled = true;
            this.issuePriority.Location = new System.Drawing.Point(65, 114);
            this.issuePriority.Name = "issuePriority";
            this.issuePriority.Size = new System.Drawing.Size(830, 21);
            this.issuePriority.TabIndex = 6;
            this.issuePriority.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.issuePriority.AutoCompleteSource = AutoCompleteSource.ListItems;    
            
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Location = new System.Drawing.Point(8, 138);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(63, 13);
            this.labelParent.Text = "Parent:";
            // 
            // parentIssue
            //             
            this.parentIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parentIssue.FormattingEnabled = true;
            this.parentIssue.Location = new System.Drawing.Point(65, 138);
            this.parentIssue.Name = "issueTracker";
            this.parentIssue.Size = new System.Drawing.Size(760, 21);
            this.parentIssue.TabIndex = 7; 
            this.parentIssue.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.parentIssue.AutoCompleteSource = AutoCompleteSource.ListItems;           
            // 
            // newIssueSync
            // 
            this.newIssueSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newIssueSync.Location = new System.Drawing.Point(825, 138);
            this.newIssueSync.Name = "newIssueSync";
            this.newIssueSync.Size = new System.Drawing.Size(75, 23);
            this.newIssueSync.Text = "SyncSave";
            this.newIssueSync.UseVisualStyleBackColor = true;  
			this.newIssueSync.TabIndex = 8;              
            this.newIssueSync.Click += new System.EventHandler(this.syncSave_Click);
            
            // 
            // labelIssueDescription
            // 
            this.labelIssueDescription.AutoSize = true;
            this.labelIssueDescription.Location = new System.Drawing.Point(8, 168);
            this.labelIssueDescription.Name = "labelIssueDescription";
            this.labelIssueDescription.Size = new System.Drawing.Size(63, 13);
            this.labelIssueDescription.Text = "Description:";
            // 
            // issueDescription
            // 
            this.issueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueDescription.Location = new System.Drawing.Point(11, 184);
            this.issueDescription.Multiline = true;
            this.issueDescription.Name = "issueDescription";
            this.issueDescription.Size = new System.Drawing.Size(877, 74);
            this.issueDescription.TabIndex = 9;
            
            // 
            // btnNewIssueStart
            // 
            this.btnNewIssueStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewIssueStart.Location = new System.Drawing.Point(813, 275);
            this.btnNewIssueStart.Name = "btnNewIssueStart";
            this.btnNewIssueStart.Size = new System.Drawing.Size(75, 23);
            this.btnNewIssueStart.TabIndex = 10;
            this.btnNewIssueStart.Text = "Upload";
            this.btnNewIssueStart.UseVisualStyleBackColor = true;
            this.btnNewIssueStart.Click += new System.EventHandler(this.newIssue);
            
            //TAB PAGE 2 ###################################################################################################

            // 
            // labelOldIssue
            // 
            this.labelOldIssue.AutoSize = true;
            this.labelOldIssue.Location = new System.Drawing.Point(6, 9);
            this.labelOldIssue.Name = "labelOldIssue";
            this.labelOldIssue.Size = new System.Drawing.Size(35, 13);
            this.labelOldIssue.Text = "Issue:";
            // 
            // labelOldIssueIdSign
            // 
            this.labelOldIssueIdSign.AutoSize = true;
            this.labelOldIssueIdSign.Location = new System.Drawing.Point(44, 9);
            this.labelOldIssueIdSign.Name = "labelOldIssueIdSign";
            this.labelOldIssueIdSign.Size = new System.Drawing.Size(14, 13);
            this.labelOldIssueIdSign.Text = "#";        
            
            
            // 
            // oldIssue
            //             
            this.oldIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldIssue.FormattingEnabled = true;
            this.oldIssue.Location = new System.Drawing.Point(65, 6);
            this.oldIssue.Name = "issueTracker";
            this.oldIssue.Size = new System.Drawing.Size(760, 21);
            this.oldIssue.TabIndex = 7;  
            this.oldIssue.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.oldIssue.AutoCompleteSource = AutoCompleteSource.ListItems;
            
			// 
            // oldIssueSync
            // 
            this.oldIssueSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oldIssueSync.Location = new System.Drawing.Point(825, 6);
            this.oldIssueSync.Name = "oldIssueSync";
            this.oldIssueSync.Size = new System.Drawing.Size(75, 23);
            this.oldIssueSync.Text = "SyncSave";
            this.oldIssueSync.UseVisualStyleBackColor = true;  
			this.oldIssueSync.TabIndex = 8;              
            this.oldIssueSync.Click += new System.EventHandler(this.syncSave_Click);           
            // 
            // issueAssigneeListUpdate
            // 
            this.issueAssigneeListUpdate.Location = new System.Drawing.Point(63, 37);
            this.issueAssigneeListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueAssigneeListUpdate.Name = "issueAssigneeListUpdate";
            this.issueAssigneeListUpdate.Size = new System.Drawing.Size(830, 21);
            this.issueAssigneeListUpdate.Text = "Check and get Userlist";
            this.issueAssigneeListUpdate.UseVisualStyleBackColor = true;            
            this.issueAssigneeListUpdate.Click += new System.EventHandler(this.issueAssigneeListUpdate_Click);
  			this.issueAssigneeListUpdate.TabIndex = 7;  

            // 
            // labelOldIssueAssignee
            // 
            this.labelOldIssueAssignee.AutoSize = true;
            this.labelOldIssueAssignee.Location = new System.Drawing.Point(6, 64);
            this.labelOldIssueAssignee.Name = "labelOldIssueAssignee";
            this.labelOldIssueAssignee.Size = new System.Drawing.Size(41, 13);
            this.labelOldIssueAssignee.Text = "Assignee:";  
            // 
            // oldissueAssignee
            // 
            this.oldissueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissueAssignee.FormattingEnabled = true;
            this.oldissueAssignee.Location = new System.Drawing.Point(63, 64);
            this.oldissueAssignee.Name = "oldissueAssignee";
            this.oldissueAssignee.Size = new System.Drawing.Size(830, 21);
            this.oldissueAssignee.TabIndex = 13;         
            this.oldissueAssignee.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.oldissueAssignee.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            // 
            // labelOldIssuePriority
            // 
            this.labelOldIssuePriority.AutoSize = true;
            this.labelOldIssuePriority.Location = new System.Drawing.Point(6, 100);
            this.labelOldIssuePriority.Name = "label12";
            this.labelOldIssuePriority.Size = new System.Drawing.Size(41, 13);
            this.labelOldIssuePriority.TabIndex = 9;
            this.labelOldIssuePriority.Text = "Priority:";
            // 
            // oldissuePriority
            // 
            this.oldissuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissuePriority.FormattingEnabled = true;
            this.oldissuePriority.Location = new System.Drawing.Point(63, 98);
            this.oldissuePriority.Name = "oldissuePriority";
            this.oldissuePriority.Size = new System.Drawing.Size(830, 21);
            this.oldissuePriority.TabIndex = 12; 
            this.oldissuePriority.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.oldissuePriority.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            // 
            // labelOldIssueStatus
            // 
            this.labelOldIssueStatus.AutoSize = true;
            this.labelOldIssueStatus.Location = new System.Drawing.Point(8, 138);
            this.labelOldIssueStatus.Name = "labelOldIssueStatus";
            this.labelOldIssueStatus.Size = new System.Drawing.Size(53, 13);
            this.labelOldIssueStatus.Text = "Status:";
             // 
            // oldissueStatus
            // 
            this.oldissueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissueStatus.FormattingEnabled = true;
            this.oldissueStatus.Location = new System.Drawing.Point(63, 138);
            this.oldissueStatus.Name = "oldissueStatus";
            this.oldissueStatus.Size = new System.Drawing.Size(830, 21);
            this.oldissueStatus.TabIndex = 14; 
            this.oldissueStatus.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.oldissueStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            
            // 
            // labelNoteDesc
            // 
            this.labelNoteDesc.AutoSize = true;
            this.labelNoteDesc.Location = new System.Drawing.Point(8, 165);
            this.labelNoteDesc.Name = "labelNoteDesc";
            this.labelNoteDesc.Size = new System.Drawing.Size(63, 13);
            this.labelNoteDesc.Text = "Note:";
			// 
            // issueNote
            // 
            this.issueNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueNote.Location = new System.Drawing.Point(11, 174);
            this.issueNote.Multiline = true;
            this.issueNote.Name = "issueNote";
            this.issueNote.Size = new System.Drawing.Size(877, 84);
            this.issueNote.TabIndex = 15; 
            
            // 
            // oldissueUpload
            // 
            this.oldissueUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissueUpload.Location = new System.Drawing.Point(811, 275);
            this.oldissueUpload.Name = "oldissueUpload";
            this.oldissueUpload.Size = new System.Drawing.Size(75, 23);
            this.oldissueUpload.TabIndex = 14;
            this.oldissueUpload.Text = "Upload";
            this.oldissueUpload.UseVisualStyleBackColor = true;
            this.oldissueUpload.Click += new System.EventHandler(this.updateIssue);
 
            
            //CONTAINER AND STUFF ###################################################################################################

            
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 133);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 300);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewIssueStart);
            this.tabPage1.Controls.Add(this.labelProject);
            this.tabPage1.Controls.Add(this.issueDescription);
            this.tabPage1.Controls.Add(this.issuePriority);
            this.tabPage1.Controls.Add(this.labelIssueDescription);
            this.tabPage1.Controls.Add(this.projectList);
            this.tabPage1.Controls.Add(this.projectAssigneeListUpdate);            
            this.tabPage1.Controls.Add(this.labelPriority);
            this.tabPage1.Controls.Add(this.issueAssignee);
            this.tabPage1.Controls.Add(this.labelSubject);
            this.tabPage1.Controls.Add(this.issueTracker);
            this.tabPage1.Controls.Add(this.issueSubject);
            this.tabPage1.Controls.Add(this.labelTracker);
            this.tabPage1.Controls.Add(this.labelAssignee);
            this.tabPage1.Controls.Add(this.labelParent);
            this.tabPage1.Controls.Add(this.newIssueSync);
            this.tabPage1.Controls.Add(this.parentIssue);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Issue";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.oldissueUpload);
            this.tabPage2.Controls.Add(this.oldissuePriority);
            this.tabPage2.Controls.Add(this.oldissueAssignee);
            this.tabPage2.Controls.Add(this.oldissueStatus);
            this.tabPage2.Controls.Add(this.issueAssigneeListUpdate);
            this.tabPage2.Controls.Add(this.labelOldIssuePriority);
            this.tabPage2.Controls.Add(this.labelOldIssueAssignee);
            this.tabPage2.Controls.Add(this.labelOldIssueStatus);
            this.tabPage2.Controls.Add(this.labelOldIssueIdSign);
            this.tabPage2.Controls.Add(this.labelOldIssue);
            this.tabPage2.Controls.Add(this.labelNoteDesc);            
            this.tabPage2.Controls.Add(this.issueNote);
            this.tabPage2.Controls.Add(this.oldIssueSync);
            this.tabPage2.Controls.Add(this.oldIssue);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attach to Issue";
            this.tabPage2.UseVisualStyleBackColor = true;           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.filesource);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.description);
            this.Text = "Ascendro S.R.L - GreenshotRedmineUploader V0.0.2";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            
            this.Width = 600;

		}
		
		
        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelOldIssue;
        private System.Windows.Forms.Label labelOldIssueIdSign;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filesource;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button btnNewIssueStart;
        private System.Windows.Forms.ComboBox issuePriority;
        private System.Windows.Forms.ComboBox issueAssignee;
        private System.Windows.Forms.ComboBox issueTracker;
        private System.Windows.Forms.TextBox issueDescription;
        private System.Windows.Forms.TextBox issueNote;
        private System.Windows.Forms.TextBox issueSubject;
        private System.Windows.Forms.Label labelIssueDescription;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelAssignee;
        private System.Windows.Forms.Label labelTracker;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelOldIssuePriority;
        private System.Windows.Forms.Label labelOldIssueAssignee;
        private System.Windows.Forms.Label labelOldIssueStatus;
        private System.Windows.Forms.Label labelNoteDesc;
        private System.Windows.Forms.Button oldissueUpload;
        private System.Windows.Forms.ComboBox oldissuePriority;
        private System.Windows.Forms.ComboBox oldissueAssignee;
        private System.Windows.Forms.ComboBox oldissueStatus;
        
        private System.Windows.Forms.Button projectAssigneeListUpdate;
        private System.Windows.Forms.Button issueAssigneeListUpdate;
        
        
        
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Button newIssueSync;
        private System.Windows.Forms.Button oldIssueSync;
        private System.Windows.Forms.ComboBox parentIssue;
        private System.Windows.Forms.ComboBox oldIssue;
	}
}
