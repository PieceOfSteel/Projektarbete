namespace Projekt_C
{
    partial class Form1
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
            this.btnAddFeed = new System.Windows.Forms.Button();
            this.txtBoxUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabCtrlFeeds = new System.Windows.Forms.TabControl();
            this.metroUserControl1 = new MetroFramework.Controls.MetroUserControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(68, 70);
            this.btnAddFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(61, 25);
            this.btnAddFeed.TabIndex = 4;
            this.btnAddFeed.Text = "Add feed";
            this.btnAddFeed.UseVisualStyleBackColor = true;
            this.btnAddFeed.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxUrl
            // 
            this.txtBoxUrl.Location = new System.Drawing.Point(68, 30);
            this.txtBoxUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUrl.Name = "txtBoxUrl";
            this.txtBoxUrl.Size = new System.Drawing.Size(117, 20);
            this.txtBoxUrl.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 32);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddFeed);
            this.groupBox1.Controls.Add(this.txtBoxUrl);
            this.groupBox1.Controls.Add(this.lblUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 544);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabCtrlFeeds
            // 
            this.tabCtrlFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlFeeds.Location = new System.Drawing.Point(220, 60);
            this.tabCtrlFeeds.Name = "tabCtrlFeeds";
            this.tabCtrlFeeds.SelectedIndex = 0;
            this.tabCtrlFeeds.Size = new System.Drawing.Size(778, 544);
            this.tabCtrlFeeds.TabIndex = 17;
            // 
            // metroUserControl1
            // 
            this.metroUserControl1.Location = new System.Drawing.Point(787, 619);
            this.metroUserControl1.Name = "metroUserControl1";
            this.metroUserControl1.Size = new System.Drawing.Size(150, 150);
            this.metroUserControl1.TabIndex = 18;
            this.metroUserControl1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 624);
            this.Controls.Add(this.metroUserControl1);
            this.Controls.Add(this.tabCtrlFeeds);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCtrlFeeds;
        private MetroFramework.Controls.MetroUserControl metroUserControl1;
    }
}

