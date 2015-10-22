/*
 * Created by SharpDevelop.
 * User: Michael Kling - Ascendro S.R.L
 * Date: 19.12.2012
 * Time: 3:26 
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GreenshotRedmineUploader
{
	partial class SettingsForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.settingsSave = new System.Windows.Forms.Button();
        	this.settingsDiscard = new System.Windows.Forms.Button();
        	this.redmineHost = new System.Windows.Forms.TextBox();
        	this.redmineDefaultProject = new System.Windows.Forms.ComboBox();
        	this.redmineAPIKey = new System.Windows.Forms.MaskedTextBox();
        	this.redmineSync = new System.Windows.Forms.Button();
        	this.redmineDefaultTracker = new System.Windows.Forms.ComboBox();
        	this.redmineDefaultPriority = new System.Windows.Forms.ComboBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.redmineCloseAfterUpload = new System.Windows.Forms.CheckBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.redmineDefaultSubject = new System.Windows.Forms.TextBox();
        	this.redmineDefaultStatus = new System.Windows.Forms.ComboBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.redmineOnlyImportOpenVersions = new System.Windows.Forms.CheckBox();
        	this.disableSSLVerification = new System.Windows.Forms.CheckBox();
        	this.label9 = new System.Windows.Forms.Label();
        	this.label10 = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.txtCustomFields = new System.Windows.Forms.TextBox();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(32, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Host:";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(12, 33);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(43, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "ApiKey:";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(11, 138);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(80, 13);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Default Project:";
        	// 
        	// settingsSave
        	// 
        	this.settingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.settingsSave.Location = new System.Drawing.Point(145, 465);
        	this.settingsSave.Name = "settingsSave";
        	this.settingsSave.Size = new System.Drawing.Size(135, 23);
        	this.settingsSave.TabIndex = 3;
        	this.settingsSave.Text = "Save Changes";
        	this.settingsSave.UseVisualStyleBackColor = true;
        	this.settingsSave.Click += new System.EventHandler(this.settingsSave_Click);
        	// 
        	// settingsDiscard
        	// 
        	this.settingsDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.settingsDiscard.Location = new System.Drawing.Point(285, 465);
        	this.settingsDiscard.Name = "settingsDiscard";
        	this.settingsDiscard.Size = new System.Drawing.Size(110, 23);
        	this.settingsDiscard.TabIndex = 4;
        	this.settingsDiscard.Text = "Discard Changes";
        	this.settingsDiscard.UseVisualStyleBackColor = true;
        	this.settingsDiscard.Click += new System.EventHandler(this.settingsDiscard_Click);
        	// 
        	// redmineHost
        	// 
        	this.redmineHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineHost.Location = new System.Drawing.Point(98, 6);
        	this.redmineHost.Name = "redmineHost";
        	this.redmineHost.Size = new System.Drawing.Size(298, 20);
        	this.redmineHost.TabIndex = 5;
        	// 
        	// redmineDefaultProject
        	// 
        	this.redmineDefaultProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineDefaultProject.FormattingEnabled = true;
        	this.redmineDefaultProject.Location = new System.Drawing.Point(98, 135);
        	this.redmineDefaultProject.Name = "redmineDefaultProject";
        	this.redmineDefaultProject.Size = new System.Drawing.Size(297, 21);
        	this.redmineDefaultProject.TabIndex = 7;
        	// 
        	// redmineAPIKey
        	// 
        	this.redmineAPIKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineAPIKey.Location = new System.Drawing.Point(98, 33);
        	this.redmineAPIKey.Name = "redmineAPIKey";
        	this.redmineAPIKey.Size = new System.Drawing.Size(298, 20);
        	this.redmineAPIKey.TabIndex = 8;
        	// 
        	// redmineSync
        	// 
        	this.redmineSync.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineSync.Location = new System.Drawing.Point(97, 105);
        	this.redmineSync.Name = "redmineSync";
        	this.redmineSync.Size = new System.Drawing.Size(297, 23);
        	this.redmineSync.TabIndex = 9;
        	this.redmineSync.Text = "Test and Synchronize (takes time = good sign)";
        	this.redmineSync.UseVisualStyleBackColor = true;
        	this.redmineSync.Click += new System.EventHandler(this.redmineSync_Click);
        	// 
        	// redmineDefaultTracker
        	// 
        	this.redmineDefaultTracker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineDefaultTracker.FormattingEnabled = true;
        	this.redmineDefaultTracker.Location = new System.Drawing.Point(97, 162);
        	this.redmineDefaultTracker.Name = "redmineDefaultTracker";
        	this.redmineDefaultTracker.Size = new System.Drawing.Size(299, 21);
        	this.redmineDefaultTracker.TabIndex = 10;
        	// 
        	// redmineDefaultPriority
        	// 
        	this.redmineDefaultPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineDefaultPriority.FormattingEnabled = true;
        	this.redmineDefaultPriority.Location = new System.Drawing.Point(97, 189);
        	this.redmineDefaultPriority.Name = "redmineDefaultPriority";
        	this.redmineDefaultPriority.Size = new System.Drawing.Size(299, 21);
        	this.redmineDefaultPriority.TabIndex = 11;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(11, 165);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(84, 13);
        	this.label4.TabIndex = 13;
        	this.label4.Text = "Default Tracker:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(11, 192);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(78, 13);
        	this.label5.TabIndex = 14;
        	this.label5.Text = "Default Priority:";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(11, 219);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(0, 13);
        	this.label6.TabIndex = 15;
        	// 
        	// redmineCloseAfterUpload
        	// 
        	this.redmineCloseAfterUpload.AutoSize = true;
        	this.redmineCloseAfterUpload.Location = new System.Drawing.Point(97, 267);
        	this.redmineCloseAfterUpload.Name = "redmineCloseAfterUpload";
        	this.redmineCloseAfterUpload.Size = new System.Drawing.Size(152, 17);
        	this.redmineCloseAfterUpload.TabIndex = 16;
        	this.redmineCloseAfterUpload.Text = "Close program after upload";
        	this.redmineCloseAfterUpload.UseVisualStyleBackColor = true;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(12, 244);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(83, 13);
        	this.label7.TabIndex = 17;
        	this.label7.Text = "Default Subject:";
        	// 
        	// redmineDefaultSubject
        	// 
        	this.redmineDefaultSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineDefaultSubject.Location = new System.Drawing.Point(97, 241);
        	this.redmineDefaultSubject.Name = "redmineDefaultSubject";
        	this.redmineDefaultSubject.Size = new System.Drawing.Size(299, 20);
        	this.redmineDefaultSubject.TabIndex = 18;
        	// 
        	// redmineDefaultStatus
        	// 
        	this.redmineDefaultStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.redmineDefaultStatus.FormattingEnabled = true;
        	this.redmineDefaultStatus.Location = new System.Drawing.Point(97, 216);
        	this.redmineDefaultStatus.Name = "redmineDefaultStatus";
        	this.redmineDefaultStatus.Size = new System.Drawing.Size(299, 21);
        	this.redmineDefaultStatus.TabIndex = 19;
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(11, 219);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(77, 13);
        	this.label8.TabIndex = 20;
        	this.label8.Text = "Default Status:";
        	// 
        	// redmineOnlyImportOpenVersions
        	// 
        	this.redmineOnlyImportOpenVersions.AutoSize = true;
        	this.redmineOnlyImportOpenVersions.Location = new System.Drawing.Point(97, 59);
        	this.redmineOnlyImportOpenVersions.Name = "redmineOnlyImportOpenVersions";
        	this.redmineOnlyImportOpenVersions.Size = new System.Drawing.Size(147, 17);
        	this.redmineOnlyImportOpenVersions.TabIndex = 21;
        	this.redmineOnlyImportOpenVersions.Text = "Only import open versions";
        	this.redmineOnlyImportOpenVersions.UseVisualStyleBackColor = true;
        	// 
        	// disableSSLVerification
        	// 
        	this.disableSSLVerification.AutoSize = true;
        	this.disableSSLVerification.Location = new System.Drawing.Point(97, 82);
        	this.disableSSLVerification.Name = "disableSSLVerification";
        	this.disableSSLVerification.Size = new System.Drawing.Size(217, 17);
        	this.disableSSLVerification.TabIndex = 22;
        	this.disableSSLVerification.Text = "Disable SSL Verification (requires restart)";
        	this.disableSSLVerification.UseVisualStyleBackColor = true;
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(12, 287);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(153, 13);
        	this.label9.TabIndex = 23;
        	this.label9.Text = "Custom Fields: (requires restart)";
        	this.label9.Click += new System.EventHandler(this.Label9Click);
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Location = new System.Drawing.Point(11, 418);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(325, 13);
        	this.label10.TabIndex = 24;
        	this.label10.Text = "Format: ID;Name;Type;Values;Default Allowed Types: list and string";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Location = new System.Drawing.Point(11, 431);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(294, 13);
        	this.label11.TabIndex = 25;
        	this.label11.Text = "Example: 1;External Status;list;Open,In Process,Closed;Open";
        	// 
        	// txtCustomFields
        	// 
        	this.txtCustomFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
        	this.txtCustomFields.Location = new System.Drawing.Point(98, 303);
        	this.txtCustomFields.Multiline = true;
        	this.txtCustomFields.Name = "txtCustomFields";
        	this.txtCustomFields.Size = new System.Drawing.Size(296, 112);
        	this.txtCustomFields.TabIndex = 26;
        	// 
        	// SettingsForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(408, 500);
        	this.Controls.Add(this.txtCustomFields);
        	this.Controls.Add(this.label11);
        	this.Controls.Add(this.label10);
        	this.Controls.Add(this.label9);
        	this.Controls.Add(this.disableSSLVerification);
        	this.Controls.Add(this.redmineOnlyImportOpenVersions);
        	this.Controls.Add(this.label8);
        	this.Controls.Add(this.redmineDefaultStatus);
        	this.Controls.Add(this.redmineDefaultSubject);
        	this.Controls.Add(this.label7);
        	this.Controls.Add(this.redmineCloseAfterUpload);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.label5);
        	this.Controls.Add(this.label4);
        	this.Controls.Add(this.redmineDefaultPriority);
        	this.Controls.Add(this.redmineDefaultTracker);
        	this.Controls.Add(this.redmineSync);
        	this.Controls.Add(this.redmineAPIKey);
        	this.Controls.Add(this.redmineDefaultProject);
        	this.Controls.Add(this.redmineHost);
        	this.Controls.Add(this.settingsDiscard);
        	this.Controls.Add(this.settingsSave);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Name = "SettingsForm";
        	this.Text = "Settings";
        	this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settings_FormClosed);
        	this.Load += new System.EventHandler(this.settings_Load);
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button settingsSave;
        private System.Windows.Forms.Button settingsDiscard;
        private System.Windows.Forms.TextBox redmineHost;
        private System.Windows.Forms.ComboBox redmineDefaultProject;
        private System.Windows.Forms.MaskedTextBox redmineAPIKey;
        private System.Windows.Forms.Button redmineSync;
        private System.Windows.Forms.ComboBox redmineDefaultTracker;
        private System.Windows.Forms.ComboBox redmineDefaultPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox redmineCloseAfterUpload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox redmineDefaultSubject;
        private System.Windows.Forms.ComboBox redmineDefaultStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox redmineOnlyImportOpenVersions;
        private System.Windows.Forms.CheckBox disableSSLVerification;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCustomFields;
	}
}
