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
			this.labelVersion = new System.Windows.Forms.Label();
			this.labelCategory = new System.Windows.Forms.Label();
			this.projectAllListUpdate = new System.Windows.Forms.Button();
			this.projectVersionListUpdate = new System.Windows.Forms.Button();
			this.projectCategoryListUpdate = new System.Windows.Forms.Button();
			this.issueVersion = new System.Windows.Forms.ComboBox();
			this.issueCategory = new System.Windows.Forms.ComboBox();
			this.projectAssigneeListUpdate = new System.Windows.Forms.Button();
			this.labelParent = new System.Windows.Forms.Label();
			this.newIssueSync = new System.Windows.Forms.Button();
			this.parentIssue = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.labelOldIssueVersion = new System.Windows.Forms.Label();
			this.labelOldIssueCategory = new System.Windows.Forms.Label();
			this.oldIssueVersion = new System.Windows.Forms.ComboBox();
			this.oldIssueCategory = new System.Windows.Forms.ComboBox();
			this.oldissueUpload = new System.Windows.Forms.Button();
			this.oldissuePriority = new System.Windows.Forms.ComboBox();
			this.oldissueAssignee = new System.Windows.Forms.ComboBox();
			this.oldissueStatus = new System.Windows.Forms.ComboBox();
			this.issueAssigneeListUpdate = new System.Windows.Forms.Button();
			this.labelOldIssuePriority = new System.Windows.Forms.Label();
			this.labelOldIssueAssignee = new System.Windows.Forms.Label();
			this.labelOldIssueStatus = new System.Windows.Forms.Label();
			this.labelNoteDesc = new System.Windows.Forms.Label();
			this.oldIssueSync = new System.Windows.Forms.Button();
			this.oldIssue = new System.Windows.Forms.ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// projectList
			// 
			this.projectList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.projectList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.projectList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.projectList.FormattingEnabled = true;
			this.projectList.Location = new System.Drawing.Point(65, 6);
			this.projectList.Name = "projectList";
			this.projectList.Size = new System.Drawing.Size(391, 21);
			this.projectList.TabIndex = 1;
			this.projectList.SelectedIndexChanged += new System.EventHandler(this.projectList_SelectedIndexChanged);
			// 
			// settings
			// 
			this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settings.Location = new System.Drawing.Point(497, 12);
			this.settings.Name = "settings";
			this.settings.Size = new System.Drawing.Size(75, 23);
			this.settings.TabIndex = 30;
			this.settings.Text = "Settings";
			this.settings.UseVisualStyleBackColor = true;
			this.settings.Click += new System.EventHandler(this.settings_Click);
			// 
			// labelProject
			// 
			this.labelProject.AutoSize = true;
			this.labelProject.Location = new System.Drawing.Point(8, 9);
			this.labelProject.Name = "labelProject";
			this.labelProject.Size = new System.Drawing.Size(43, 13);
			this.labelProject.TabIndex = 11;
			this.labelProject.Text = "Project:";
			// 
			// labelOldIssue
			// 
			this.labelOldIssue.AutoSize = true;
			this.labelOldIssue.Location = new System.Drawing.Point(6, 9);
			this.labelOldIssue.Name = "labelOldIssue";
			this.labelOldIssue.Size = new System.Drawing.Size(35, 13);
			this.labelOldIssue.TabIndex = 18;
			this.labelOldIssue.Text = "Issue:";
			// 
			// labelOldIssueIdSign
			// 
			this.labelOldIssueIdSign.AutoSize = true;
			this.labelOldIssueIdSign.Location = new System.Drawing.Point(44, 9);
			this.labelOldIssueIdSign.Name = "labelOldIssueIdSign";
			this.labelOldIssueIdSign.Size = new System.Drawing.Size(14, 13);
			this.labelOldIssueIdSign.TabIndex = 17;
			this.labelOldIssueIdSign.Text = "#";
			// 
			// labelFilename
			// 
			this.labelFilename.AutoSize = true;
			this.labelFilename.Location = new System.Drawing.Point(12, 70);
			this.labelFilename.Name = "labelFilename";
			this.labelFilename.Size = new System.Drawing.Size(52, 13);
			this.labelFilename.TabIndex = 18;
			this.labelFilename.Text = "Filename:";
			// 
			// filename
			// 
			this.filename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.filename.Location = new System.Drawing.Point(74, 67);
			this.filename.Name = "filename";
			this.filename.Size = new System.Drawing.Size(501, 20);
			this.filename.TabIndex = 10;
			// 
			// labelDesc
			// 
			this.labelDesc.AutoSize = true;
			this.labelDesc.Location = new System.Drawing.Point(12, 100);
			this.labelDesc.Name = "labelDesc";
			this.labelDesc.Size = new System.Drawing.Size(63, 13);
			this.labelDesc.TabIndex = 31;
			this.labelDesc.Text = "Description:";
			// 
			// description
			// 
			this.description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.description.Location = new System.Drawing.Point(74, 97);
			this.description.Name = "description";
			this.description.Size = new System.Drawing.Size(501, 20);
			this.description.TabIndex = 11;
			// 
			// labelFile
			// 
			this.labelFile.AutoSize = true;
			this.labelFile.Location = new System.Drawing.Point(12, 44);
			this.labelFile.Name = "labelFile";
			this.labelFile.Size = new System.Drawing.Size(26, 13);
			this.labelFile.TabIndex = 17;
			this.labelFile.Text = "File:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// filesource
			// 
			this.filesource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.filesource.Location = new System.Drawing.Point(74, 41);
			this.filesource.Name = "filesource";
			this.filesource.Size = new System.Drawing.Size(417, 20);
			this.filesource.TabIndex = 13;
			// 
			// openFile
			// 
			this.openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.openFile.Location = new System.Drawing.Point(497, 41);
			this.openFile.Name = "openFile";
			this.openFile.Size = new System.Drawing.Size(75, 23);
			this.openFile.TabIndex = 14;
			this.openFile.Text = "Open";
			this.openFile.UseVisualStyleBackColor = true;
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// btnNewIssueStart
			// 
			this.btnNewIssueStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewIssueStart.Location = new System.Drawing.Point(462, 309);
			this.btnNewIssueStart.Name = "btnNewIssueStart";
			this.btnNewIssueStart.Size = new System.Drawing.Size(75, 23);
			this.btnNewIssueStart.TabIndex = 10;
			this.btnNewIssueStart.Text = "Upload";
			this.btnNewIssueStart.UseVisualStyleBackColor = true;
			this.btnNewIssueStart.Click += new System.EventHandler(this.newIssue);
			// 
			// issuePriority
			// 
			this.issuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issuePriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.issuePriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.issuePriority.FormattingEnabled = true;
			this.issuePriority.Location = new System.Drawing.Point(65, 114);
			this.issuePriority.Name = "issuePriority";
			this.issuePriority.Size = new System.Drawing.Size(479, 21);
			this.issuePriority.TabIndex = 6;
			// 
			// issueAssignee
			// 
			this.issueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueAssignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.issueAssignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.issueAssignee.FormattingEnabled = true;
			this.issueAssignee.Location = new System.Drawing.Point(65, 87);
			this.issueAssignee.Name = "issueAssignee";
			this.issueAssignee.Size = new System.Drawing.Size(391, 21);
			this.issueAssignee.TabIndex = 5;
			// 
			// issueTracker
			// 
			this.issueTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueTracker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.issueTracker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.issueTracker.FormattingEnabled = true;
			this.issueTracker.Location = new System.Drawing.Point(65, 63);
			this.issueTracker.Name = "issueTracker";
			this.issueTracker.Size = new System.Drawing.Size(479, 21);
			this.issueTracker.TabIndex = 4;
			// 
			// issueDescription
			// 
			this.issueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueDescription.Location = new System.Drawing.Point(11, 229);
			this.issueDescription.Multiline = true;
			this.issueDescription.Name = "issueDescription";
			this.issueDescription.Size = new System.Drawing.Size(526, 63);
			this.issueDescription.TabIndex = 9;
			// 
			// issueNote
			// 
			this.issueNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueNote.Location = new System.Drawing.Point(11, 212);
			this.issueNote.Multiline = true;
			this.issueNote.Name = "issueNote";
			this.issueNote.Size = new System.Drawing.Size(526, 80);
			this.issueNote.TabIndex = 15;
			// 
			// issueSubject
			// 
			this.issueSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueSubject.Location = new System.Drawing.Point(65, 37);
			this.issueSubject.Name = "issueSubject";
			this.issueSubject.Size = new System.Drawing.Size(479, 20);
			this.issueSubject.TabIndex = 3;
			// 
			// labelIssueDescription
			// 
			this.labelIssueDescription.AutoSize = true;
			this.labelIssueDescription.Location = new System.Drawing.Point(8, 213);
			this.labelIssueDescription.Name = "labelIssueDescription";
			this.labelIssueDescription.Size = new System.Drawing.Size(63, 13);
			this.labelIssueDescription.TabIndex = 12;
			this.labelIssueDescription.Text = "Description:";
			// 
			// labelPriority
			// 
			this.labelPriority.AutoSize = true;
			this.labelPriority.Location = new System.Drawing.Point(8, 117);
			this.labelPriority.Name = "labelPriority";
			this.labelPriority.Size = new System.Drawing.Size(41, 13);
			this.labelPriority.TabIndex = 13;
			this.labelPriority.Text = "Priority:";
			// 
			// labelAssignee
			// 
			this.labelAssignee.AutoSize = true;
			this.labelAssignee.Location = new System.Drawing.Point(6, 90);
			this.labelAssignee.Name = "labelAssignee";
			this.labelAssignee.Size = new System.Drawing.Size(53, 13);
			this.labelAssignee.TabIndex = 16;
			this.labelAssignee.Text = "Assignee:";
			// 
			// labelTracker
			// 
			this.labelTracker.AutoSize = true;
			this.labelTracker.Location = new System.Drawing.Point(6, 65);
			this.labelTracker.Name = "labelTracker";
			this.labelTracker.Size = new System.Drawing.Size(47, 13);
			this.labelTracker.TabIndex = 15;
			this.labelTracker.Text = "Tracker:";
			// 
			// labelSubject
			// 
			this.labelSubject.AutoSize = true;
			this.labelSubject.Location = new System.Drawing.Point(8, 40);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(46, 13);
			this.labelSubject.TabIndex = 14;
			this.labelSubject.Text = "Subject:";
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
			this.tabControl1.Size = new System.Drawing.Size(560, 364);
			this.tabControl1.TabIndex = 16;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.labelVersion);
			this.tabPage1.Controls.Add(this.labelCategory);
			this.tabPage1.Controls.Add(this.projectAllListUpdate);
			this.tabPage1.Controls.Add(this.projectVersionListUpdate);
			this.tabPage1.Controls.Add(this.projectCategoryListUpdate);
			this.tabPage1.Controls.Add(this.issueVersion);
			this.tabPage1.Controls.Add(this.issueCategory);
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
			this.tabPage1.Size = new System.Drawing.Size(552, 338);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "New Issue";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// labelVersion
			// 
			this.labelVersion.AutoSize = true;
			this.labelVersion.Location = new System.Drawing.Point(8, 192);
			this.labelVersion.Name = "labelVersion";
			this.labelVersion.Size = new System.Drawing.Size(45, 13);
			this.labelVersion.TabIndex = 24;
			this.labelVersion.Text = "Version:";
			// 
			// labelCategory
			// 
			this.labelCategory.AutoSize = true;
			this.labelCategory.Location = new System.Drawing.Point(6, 170);
			this.labelCategory.Name = "labelCategory";
			this.labelCategory.Size = new System.Drawing.Size(52, 13);
			this.labelCategory.TabIndex = 23;
			this.labelCategory.Text = "Category:";
			// 
			// projectAllListUpdate
			// 
			this.projectAllListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.projectAllListUpdate.Location = new System.Drawing.Point(462, 4);
			this.projectAllListUpdate.Name = "projectAllListUpdate";
			this.projectAllListUpdate.Size = new System.Drawing.Size(82, 23);
			this.projectAllListUpdate.TabIndex = 22;
			this.projectAllListUpdate.Text = "Get Data";
			this.projectAllListUpdate.UseVisualStyleBackColor = true;
			this.projectAllListUpdate.Click += new System.EventHandler(this.ProjectAllListUpdateClick);
			// 
			// projectVersionListUpdate
			// 
			this.projectVersionListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.projectVersionListUpdate.Location = new System.Drawing.Point(462, 189);
			this.projectVersionListUpdate.Name = "projectVersionListUpdate";
			this.projectVersionListUpdate.Size = new System.Drawing.Size(87, 23);
			this.projectVersionListUpdate.TabIndex = 21;
			this.projectVersionListUpdate.Text = "Get Versions";
			this.projectVersionListUpdate.UseVisualStyleBackColor = true;
			this.projectVersionListUpdate.Click += new System.EventHandler(this.ProjectVersionListUpdateClick);
			// 
			// projectCategoryListUpdate
			// 
			this.projectCategoryListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.projectCategoryListUpdate.Location = new System.Drawing.Point(462, 165);
			this.projectCategoryListUpdate.Name = "projectCategoryListUpdate";
			this.projectCategoryListUpdate.Size = new System.Drawing.Size(87, 23);
			this.projectCategoryListUpdate.TabIndex = 20;
			this.projectCategoryListUpdate.Text = "Get Categories";
			this.projectCategoryListUpdate.UseVisualStyleBackColor = true;
			this.projectCategoryListUpdate.Click += new System.EventHandler(this.ProjectCategoryListUpdateClick);
			// 
			// issueVersion
			// 
			this.issueVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueVersion.FormattingEnabled = true;
			this.issueVersion.Location = new System.Drawing.Point(65, 189);
			this.issueVersion.Name = "issueVersion";
			this.issueVersion.Size = new System.Drawing.Size(391, 21);
			this.issueVersion.TabIndex = 19;
			// 
			// issueCategory
			// 
			this.issueCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueCategory.FormattingEnabled = true;
			this.issueCategory.Location = new System.Drawing.Point(65, 165);
			this.issueCategory.Name = "issueCategory";
			this.issueCategory.Size = new System.Drawing.Size(391, 21);
			this.issueCategory.TabIndex = 18;
			// 
			// projectAssigneeListUpdate
			// 
			this.projectAssigneeListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.projectAssigneeListUpdate.Location = new System.Drawing.Point(462, 85);
			this.projectAssigneeListUpdate.Name = "projectAssigneeListUpdate";
			this.projectAssigneeListUpdate.Size = new System.Drawing.Size(87, 23);
			this.projectAssigneeListUpdate.TabIndex = 2;
			this.projectAssigneeListUpdate.Text = "Get Userlist";
			this.projectAssigneeListUpdate.UseVisualStyleBackColor = true;
			this.projectAssigneeListUpdate.Click += new System.EventHandler(this.projectAssigneeListUpdate_Click);
			// 
			// labelParent
			// 
			this.labelParent.AutoSize = true;
			this.labelParent.Location = new System.Drawing.Point(8, 143);
			this.labelParent.Name = "labelParent";
			this.labelParent.Size = new System.Drawing.Size(41, 13);
			this.labelParent.TabIndex = 17;
			this.labelParent.Text = "Parent:";
			// 
			// newIssueSync
			// 
			this.newIssueSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newIssueSync.Location = new System.Drawing.Point(462, 138);
			this.newIssueSync.Name = "newIssueSync";
			this.newIssueSync.Size = new System.Drawing.Size(87, 23);
			this.newIssueSync.TabIndex = 8;
			this.newIssueSync.Text = "Sync Issues";
			this.newIssueSync.UseVisualStyleBackColor = true;
			this.newIssueSync.Click += new System.EventHandler(this.syncSave_Click);
			// 
			// parentIssue
			// 
			this.parentIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.parentIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.parentIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.parentIssue.FormattingEnabled = true;
			this.parentIssue.Location = new System.Drawing.Point(65, 138);
			this.parentIssue.Name = "parentIssue";
			this.parentIssue.Size = new System.Drawing.Size(391, 21);
			this.parentIssue.TabIndex = 7;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.labelOldIssueVersion);
			this.tabPage2.Controls.Add(this.labelOldIssueCategory);
			this.tabPage2.Controls.Add(this.oldIssueVersion);
			this.tabPage2.Controls.Add(this.oldIssueCategory);
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
			this.tabPage2.Size = new System.Drawing.Size(552, 338);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Attach to Issue";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// labelOldIssueVersion
			// 
			this.labelOldIssueVersion.AutoSize = true;
			this.labelOldIssueVersion.Location = new System.Drawing.Point(8, 167);
			this.labelOldIssueVersion.Name = "labelOldIssueVersion";
			this.labelOldIssueVersion.Size = new System.Drawing.Size(45, 13);
			this.labelOldIssueVersion.TabIndex = 23;
			this.labelOldIssueVersion.Text = "Version:";
			// 
			// labelOldIssueCategory
			// 
			this.labelOldIssueCategory.AutoSize = true;
			this.labelOldIssueCategory.Location = new System.Drawing.Point(8, 140);
			this.labelOldIssueCategory.Name = "labelOldIssueCategory";
			this.labelOldIssueCategory.Size = new System.Drawing.Size(52, 13);
			this.labelOldIssueCategory.TabIndex = 22;
			this.labelOldIssueCategory.Text = "Category:";
			// 
			// oldIssueVersion
			// 
			this.oldIssueVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldIssueVersion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldIssueVersion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.oldIssueVersion.FormattingEnabled = true;
			this.oldIssueVersion.Location = new System.Drawing.Point(63, 164);
			this.oldIssueVersion.Name = "oldIssueVersion";
			this.oldIssueVersion.Size = new System.Drawing.Size(479, 21);
			this.oldIssueVersion.TabIndex = 21;
			// 
			// oldIssueCategory
			// 
			this.oldIssueCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldIssueCategory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldIssueCategory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.oldIssueCategory.FormattingEnabled = true;
			this.oldIssueCategory.Location = new System.Drawing.Point(63, 137);
			this.oldIssueCategory.Name = "oldIssueCategory";
			this.oldIssueCategory.Size = new System.Drawing.Size(479, 21);
			this.oldIssueCategory.TabIndex = 20;
			// 
			// oldissueUpload
			// 
			this.oldissueUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.oldissueUpload.Location = new System.Drawing.Point(460, 309);
			this.oldissueUpload.Name = "oldissueUpload";
			this.oldissueUpload.Size = new System.Drawing.Size(75, 23);
			this.oldissueUpload.TabIndex = 14;
			this.oldissueUpload.Text = "Upload";
			this.oldissueUpload.UseVisualStyleBackColor = true;
			this.oldissueUpload.Click += new System.EventHandler(this.updateIssue);
			// 
			// oldissuePriority
			// 
			this.oldissuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldissuePriority.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldissuePriority.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.oldissuePriority.FormattingEnabled = true;
			this.oldissuePriority.Location = new System.Drawing.Point(63, 83);
			this.oldissuePriority.Name = "oldissuePriority";
			this.oldissuePriority.Size = new System.Drawing.Size(479, 21);
			this.oldissuePriority.TabIndex = 12;
			// 
			// oldissueAssignee
			// 
			this.oldissueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldissueAssignee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldissueAssignee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.oldissueAssignee.FormattingEnabled = true;
			this.oldissueAssignee.Location = new System.Drawing.Point(63, 56);
			this.oldissueAssignee.Name = "oldissueAssignee";
			this.oldissueAssignee.Size = new System.Drawing.Size(479, 21);
			this.oldissueAssignee.TabIndex = 13;
			// 
			// oldissueStatus
			// 
			this.oldissueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldissueStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldissueStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.oldissueStatus.FormattingEnabled = true;
			this.oldissueStatus.Location = new System.Drawing.Point(63, 110);
			this.oldissueStatus.Name = "oldissueStatus";
			this.oldissueStatus.Size = new System.Drawing.Size(479, 21);
			this.oldissueStatus.TabIndex = 14;
			// 
			// issueAssigneeListUpdate
			// 
			this.issueAssigneeListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.issueAssigneeListUpdate.Location = new System.Drawing.Point(63, 33);
			this.issueAssigneeListUpdate.Name = "issueAssigneeListUpdate";
			this.issueAssigneeListUpdate.Size = new System.Drawing.Size(479, 21);
			this.issueAssigneeListUpdate.TabIndex = 7;
			this.issueAssigneeListUpdate.Text = "Check and get Projectdata";
			this.issueAssigneeListUpdate.UseVisualStyleBackColor = true;
			this.issueAssigneeListUpdate.Click += new System.EventHandler(this.issueAssigneeListUpdate_Click);
			// 
			// labelOldIssuePriority
			// 
			this.labelOldIssuePriority.AutoSize = true;
			this.labelOldIssuePriority.Location = new System.Drawing.Point(6, 86);
			this.labelOldIssuePriority.Name = "labelOldIssuePriority";
			this.labelOldIssuePriority.Size = new System.Drawing.Size(41, 13);
			this.labelOldIssuePriority.TabIndex = 9;
			this.labelOldIssuePriority.Text = "Priority:";
			// 
			// labelOldIssueAssignee
			// 
			this.labelOldIssueAssignee.AutoSize = true;
			this.labelOldIssueAssignee.Location = new System.Drawing.Point(6, 59);
			this.labelOldIssueAssignee.Name = "labelOldIssueAssignee";
			this.labelOldIssueAssignee.Size = new System.Drawing.Size(53, 13);
			this.labelOldIssueAssignee.TabIndex = 15;
			this.labelOldIssueAssignee.Text = "Assignee:";
			// 
			// labelOldIssueStatus
			// 
			this.labelOldIssueStatus.AutoSize = true;
			this.labelOldIssueStatus.Location = new System.Drawing.Point(8, 113);
			this.labelOldIssueStatus.Name = "labelOldIssueStatus";
			this.labelOldIssueStatus.Size = new System.Drawing.Size(40, 13);
			this.labelOldIssueStatus.TabIndex = 16;
			this.labelOldIssueStatus.Text = "Status:";
			// 
			// labelNoteDesc
			// 
			this.labelNoteDesc.AutoSize = true;
			this.labelNoteDesc.Location = new System.Drawing.Point(8, 196);
			this.labelNoteDesc.Name = "labelNoteDesc";
			this.labelNoteDesc.Size = new System.Drawing.Size(33, 13);
			this.labelNoteDesc.TabIndex = 19;
			this.labelNoteDesc.Text = "Note:";
			// 
			// oldIssueSync
			// 
			this.oldIssueSync.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.oldIssueSync.Location = new System.Drawing.Point(474, 6);
			this.oldIssueSync.Name = "oldIssueSync";
			this.oldIssueSync.Size = new System.Drawing.Size(75, 23);
			this.oldIssueSync.TabIndex = 8;
			this.oldIssueSync.Text = "SyncSave";
			this.oldIssueSync.UseVisualStyleBackColor = true;
			this.oldIssueSync.Click += new System.EventHandler(this.syncSave_Click);
			// 
			// oldIssue
			// 
			this.oldIssue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.oldIssue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.oldIssue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.oldIssue.FormattingEnabled = true;
			this.oldIssue.Location = new System.Drawing.Point(65, 6);
			this.oldIssue.Name = "oldIssue";
			this.oldIssue.Size = new System.Drawing.Size(409, 21);
			this.oldIssue.TabIndex = 7;
			this.oldIssue.TextChanged += new System.EventHandler(this.OldIssueTextChanged);
			this.oldIssue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OldIssueKeyPress);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 499);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.openFile);
			this.Controls.Add(this.filesource);
			this.Controls.Add(this.labelFile);
			this.Controls.Add(this.filename);
			this.Controls.Add(this.labelFilename);
			this.Controls.Add(this.settings);
			this.Controls.Add(this.labelDesc);
			this.Controls.Add(this.description);
			this.Icon = global::GreenshotRedmineUploader.Resources.Icon;
			this.Name = "MainForm";
			this.Text = "Ascendro S.R.L - GreenshotRedmineUploader V0.0.3";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox oldIssueCategory;
		private System.Windows.Forms.ComboBox oldIssueVersion;
		private System.Windows.Forms.Label labelOldIssueCategory;
		private System.Windows.Forms.Label labelOldIssueVersion;
		private System.Windows.Forms.ComboBox issueCategory;
		private System.Windows.Forms.ComboBox issueVersion;
		private System.Windows.Forms.Button projectCategoryListUpdate;
		private System.Windows.Forms.Button projectVersionListUpdate;
		private System.Windows.Forms.Button projectAllListUpdate;
		private System.Windows.Forms.Label labelCategory;
		private System.Windows.Forms.Label labelVersion;
		
		
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
