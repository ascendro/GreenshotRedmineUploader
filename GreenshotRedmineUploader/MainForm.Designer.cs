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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.oldissueID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filename = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.filesource = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.btnNewIssueStart = new System.Windows.Forms.Button();
            this.issuePriority = new System.Windows.Forms.ComboBox();
            this.issueAssignee = new System.Windows.Forms.ComboBox();
            this.issueTracker = new System.Windows.Forms.ComboBox();
            this.issueParent = new System.Windows.Forms.ComboBox();
            this.issueDescription = new System.Windows.Forms.TextBox();
            this.issueSubject = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.oldissueUpload = new System.Windows.Forms.Button();
            this.oldissuePriority = new System.Windows.Forms.ComboBox();
            this.oldissueAssignee = new System.Windows.Forms.ComboBox();
            this.oldissueStatus = new System.Windows.Forms.ComboBox();
            
            this.projectAssigneeListUpdate = new System.Windows.Forms.Button();
        	this.issueAssigneeListUpdate = new System.Windows.Forms.Button();
            
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // projectAssigneeListUpdate
            // 
            this.projectAssigneeListUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectAssigneeListUpdate.Location = new System.Drawing.Point(825, 4);
            this.projectAssigneeListUpdate.Name = "projectAssigneeListUpdate";
            this.projectAssigneeListUpdate.Size = new System.Drawing.Size(75, 23);
            this.projectAssigneeListUpdate.Text = "Get Userlist";
            this.projectAssigneeListUpdate.UseVisualStyleBackColor = true;            
            this.projectAssigneeListUpdate.Click += new System.EventHandler(this.projectAssigneeListUpdate_Click);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Location = new System.Drawing.Point(848, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(75, 23);
            this.settings.TabIndex = 2;
            this.settings.Text = "Settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Project:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issue:";
            // 
            // oldissueID
            // 
            this.oldissueID.Location = new System.Drawing.Point(84, 6);
            this.oldissueID.Name = "oldissueID";
            this.oldissueID.Size = new System.Drawing.Size(60, 20);
            this.oldissueID.TabIndex = 6;
            // 
            // issueAssigneeListUpdate
            // 
            this.issueAssigneeListUpdate.Location = new System.Drawing.Point(154, 4);
            this.issueAssigneeListUpdate.Name = "issueAssigneeListUpdate";
            this.issueAssigneeListUpdate.Size = new System.Drawing.Size(145, 23);
            this.issueAssigneeListUpdate.Text = "Check and get Userlist";
            this.issueAssigneeListUpdate.UseVisualStyleBackColor = true;            
            this.issueAssigneeListUpdate.Click += new System.EventHandler(this.issueAssigneeListUpdate_Click);
            // 
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filename:";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "File:";
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
            this.filesource.Size = new System.Drawing.Size(768, 20);
            this.filesource.TabIndex = 13;
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
            // 
            // issuePriority
            // 
            this.issuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issuePriority.FormattingEnabled = true;
            this.issuePriority.Location = new System.Drawing.Point(65, 114);
            this.issuePriority.Name = "issuePriority";
            this.issuePriority.Size = new System.Drawing.Size(830, 21);
            this.issuePriority.TabIndex = 9;
            // 
            // issueAssignee
            // 
            this.issueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueAssignee.FormattingEnabled = true;
            this.issueAssignee.Location = new System.Drawing.Point(65, 87);
            this.issueAssignee.Name = "issueAssignee";
            this.issueAssignee.Size = new System.Drawing.Size(830, 21);
            this.issueAssignee.TabIndex = 8;
            // 
            // issueTracker
            // 
            this.issueTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueTracker.FormattingEnabled = true;
            this.issueTracker.Location = new System.Drawing.Point(65, 63);
            this.issueTracker.Name = "issueTracker";
            this.issueTracker.Size = new System.Drawing.Size(830, 21);
            this.issueTracker.TabIndex = 7;
            // 
            // issueParent
            //             
            this.issueParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueParent.FormattingEnabled = true;
            this.issueParent.Location = new System.Drawing.Point(65, 63);
            this.issueParent.Name = "issueTracker";
            this.issueParent.Size = new System.Drawing.Size(830, 21);
            this.issueParent.TabIndex = 7;
            // 
            // issueDescription
            // 
            this.issueDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueDescription.Location = new System.Drawing.Point(11, 154);
            this.issueDescription.Multiline = true;
            this.issueDescription.Name = "issueDescription";
            this.issueDescription.Size = new System.Drawing.Size(877, 104);
            this.issueDescription.TabIndex = 6;
            // 
            // issueSubject
            // 
            this.issueSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.issueSubject.Location = new System.Drawing.Point(65, 37);
            this.issueSubject.Name = "issueSubject";
            this.issueSubject.Size = new System.Drawing.Size(830, 20);
            this.issueSubject.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Assignee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tracker:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subject:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 330);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewIssueStart);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.issueDescription);
            this.tabPage1.Controls.Add(this.issuePriority);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.projectList);
            this.tabPage1.Controls.Add(this.projectAssigneeListUpdate);            
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.issueAssignee);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.issueTracker);
            this.tabPage1.Controls.Add(this.issueSubject);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
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
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.oldissueID);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attach to Issue";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Priority:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Assignee:";
            // 
            // label13
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Status:";
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
            // 
            // oldissuePriority
            // 
            this.oldissuePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissuePriority.FormattingEnabled = true;
            this.oldissuePriority.Location = new System.Drawing.Point(63, 64);
            this.oldissuePriority.Name = "oldissuePriority";
            this.oldissuePriority.Size = new System.Drawing.Size(830, 21);
            this.oldissuePriority.TabIndex = 12;
            // 
            // oldissueAssignee
            // 
            this.oldissueAssignee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissueAssignee.FormattingEnabled = true;
            this.oldissueAssignee.Location = new System.Drawing.Point(63, 37);
            this.oldissueAssignee.Name = "oldissueAssignee";
            this.oldissueAssignee.Size = new System.Drawing.Size(830, 21);
            this.oldissueAssignee.TabIndex = 13;
            // 
            // oldissueStatus
            // 
            this.oldissueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.oldissueStatus.FormattingEnabled = true;
            this.oldissueStatus.Location = new System.Drawing.Point(63, 98);
            this.oldissueStatus.Name = "oldissueStatus";
            this.oldissueStatus.Size = new System.Drawing.Size(830, 21);
            this.oldissueStatus.TabIndex = 14;            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 435);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.filesource);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.settings);
            this.Text = "Ascendro S.R.L - GreenshotRedmineUploader";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            
            this.Width = 400;

		}
		
		
        private System.Windows.Forms.ComboBox projectList;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldissueID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox filesource;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button btnNewIssueStart;
        private System.Windows.Forms.ComboBox issuePriority;
        private System.Windows.Forms.ComboBox issueAssignee;
        private System.Windows.Forms.ComboBox issueTracker;
        private System.Windows.Forms.ComboBox issueParent;
        private System.Windows.Forms.TextBox issueDescription;
        private System.Windows.Forms.TextBox issueSubject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button oldissueUpload;
        private System.Windows.Forms.ComboBox oldissuePriority;
        private System.Windows.Forms.ComboBox oldissueAssignee;
        private System.Windows.Forms.ComboBox oldissueStatus;
        
        private System.Windows.Forms.Button projectAssigneeListUpdate;
        private System.Windows.Forms.Button issueAssigneeListUpdate;
	}
}
