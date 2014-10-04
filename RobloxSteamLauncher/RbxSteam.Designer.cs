namespace RobloxSteamLauncher
{
    partial class RbxSteam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RbxSteam));
            this.LaunchButton = new System.Windows.Forms.Button();
            this.placeInput = new System.Windows.Forms.TextBox();
            this.PlaceIDTitle = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.directoryInput = new System.Windows.Forms.TextBox();
            this.DirectoryTitle = new System.Windows.Forms.Label();
            this.searchFor = new System.Windows.Forms.Button();
            this.searchDialog = new System.Windows.Forms.OpenFileDialog();
            this.credit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchButton
            // 
            this.LaunchButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LaunchButton.Location = new System.Drawing.Point(149, 212);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(167, 44);
            this.LaunchButton.TabIndex = 0;
            this.LaunchButton.Text = "Launch!";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // placeInput
            // 
            this.placeInput.Location = new System.Drawing.Point(12, 225);
            this.placeInput.Name = "placeInput";
            this.placeInput.Size = new System.Drawing.Size(114, 20);
            this.placeInput.TabIndex = 1;
            // 
            // PlaceIDTitle
            // 
            this.PlaceIDTitle.AutoSize = true;
            this.PlaceIDTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PlaceIDTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceIDTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PlaceIDTitle.Location = new System.Drawing.Point(8, 198);
            this.PlaceIDTitle.Name = "PlaceIDTitle";
            this.PlaceIDTitle.Size = new System.Drawing.Size(106, 24);
            this.PlaceIDTitle.TabIndex = 2;
            this.PlaceIDTitle.Text = "PlaceID:";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(304, 141);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // directoryInput
            // 
            this.directoryInput.Location = new System.Drawing.Point(12, 175);
            this.directoryInput.Name = "directoryInput";
            this.directoryInput.ReadOnly = true;
            this.directoryInput.Size = new System.Drawing.Size(260, 20);
            this.directoryInput.TabIndex = 4;
            // 
            // DirectoryTitle
            // 
            this.DirectoryTitle.AutoSize = true;
            this.DirectoryTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DirectoryTitle.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DirectoryTitle.Location = new System.Drawing.Point(8, 148);
            this.DirectoryTitle.Name = "DirectoryTitle";
            this.DirectoryTitle.Size = new System.Drawing.Size(238, 24);
            this.DirectoryTitle.TabIndex = 5;
            this.DirectoryTitle.Text = "Roblox Application:";
            // 
            // searchFor
            // 
            this.searchFor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchFor.Location = new System.Drawing.Point(278, 175);
            this.searchFor.Name = "searchFor";
            this.searchFor.Size = new System.Drawing.Size(38, 20);
            this.searchFor.TabIndex = 6;
            this.searchFor.Text = "...";
            this.searchFor.UseVisualStyleBackColor = true;
            this.searchFor.Click += new System.EventHandler(this.searchFor_Click);
            // 
            // searchDialog
            // 
            this.searchDialog.Filter = "RobloxPlayerBeta | *.exe";
            this.searchDialog.InitialDirectory = "C:\\Users\\Maxwell\\AppData\\Local";
            this.searchDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.searchDialog_FileOk);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.ForeColor = System.Drawing.SystemColors.Control;
            this.credit.Location = new System.Drawing.Point(9, 263);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(163, 13);
            this.credit.TabIndex = 7;
            this.credit.Text = "@ CloneTrooper1019, 2014 (Version 1.0)";
            // 
            // RbxSteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(328, 285);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.searchFor);
            this.Controls.Add(this.DirectoryTitle);
            this.Controls.Add(this.directoryInput);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.PlaceIDTitle);
            this.Controls.Add(this.placeInput);
            this.Controls.Add(this.LaunchButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RbxSteam";
            this.Text = "Roblox For Steam";
            this.Load += new System.EventHandler(this.RbxSteam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.TextBox placeInput;
        private System.Windows.Forms.Label PlaceIDTitle;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox directoryInput;
        private System.Windows.Forms.Label DirectoryTitle;
        private System.Windows.Forms.Button searchFor;
        private System.Windows.Forms.OpenFileDialog searchDialog;
        private System.Windows.Forms.Label credit;
    }
}

