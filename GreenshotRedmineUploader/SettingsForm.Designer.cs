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
        	System.Resources.ResourceManager resources = new System.Resources.ResourceManager("GreenshotRedmineUploader.Resources",System.Reflection.Assembly.GetExecutingAssembly());
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
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Default Project:";
            // 
            // settingsSave
            // 
            this.settingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsSave.Location = new System.Drawing.Point(145, 258);
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
            this.settingsDiscard.Location = new System.Drawing.Point(286, 258);
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
            this.redmineDefaultProject.Location = new System.Drawing.Point(99, 89);
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
            this.redmineSync.Location = new System.Drawing.Point(98, 59);
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
            this.redmineDefaultTracker.Location = new System.Drawing.Point(98, 116);
            this.redmineDefaultTracker.Name = "redmineDefaultTracker";
            this.redmineDefaultTracker.Size = new System.Drawing.Size(297, 21);
            this.redmineDefaultTracker.TabIndex = 10;
            // 
            // redmineDefaultPriority
            // 
            this.redmineDefaultPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.redmineDefaultPriority.FormattingEnabled = true;
            this.redmineDefaultPriority.Location = new System.Drawing.Point(98, 143);
            this.redmineDefaultPriority.Name = "redmineDefaultPriority";
            this.redmineDefaultPriority.Size = new System.Drawing.Size(297, 21);
            this.redmineDefaultPriority.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Default Tracker:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Default Priority:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // redmineCloseAfterUpload
            // 
            this.redmineCloseAfterUpload.AutoSize = true;
            this.redmineCloseAfterUpload.Location = new System.Drawing.Point(97, 221);
            this.redmineCloseAfterUpload.Name = "redmineCloseAfterUpload";
            this.redmineCloseAfterUpload.Size = new System.Drawing.Size(152, 17);
            this.redmineCloseAfterUpload.TabIndex = 16;
            this.redmineCloseAfterUpload.Text = "Close program after upload";
            this.redmineCloseAfterUpload.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Default Subject:";
            // 
            // redmineDefaultSubject
            // 
            this.redmineDefaultSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.redmineDefaultSubject.Location = new System.Drawing.Point(99, 195);
            this.redmineDefaultSubject.Name = "redmineDefaultSubject";
            this.redmineDefaultSubject.Size = new System.Drawing.Size(298, 20);
            this.redmineDefaultSubject.TabIndex = 18;
            // 
            // redmineDefaultStatus
            // 
            this.redmineDefaultStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.redmineDefaultStatus.FormattingEnabled = true;
            this.redmineDefaultStatus.Location = new System.Drawing.Point(97, 170);
            this.redmineDefaultStatus.Name = "redmineDefaultStatus";
            this.redmineDefaultStatus.Size = new System.Drawing.Size(297, 21);
            this.redmineDefaultStatus.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Default Status:";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 293);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("Icon")));
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
            this.Name = "settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.settings_FormClosed);
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
	}
}
