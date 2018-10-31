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
            this.txtBoxNameOfFeed = new System.Windows.Forms.TextBox();
            this.lblNameOfFeed = new System.Windows.Forms.Label();
            this.grpBoxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategories = new System.Windows.Forms.Label();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFeed
            // 
            this.btnAddFeed.Location = new System.Drawing.Point(68, 155);
            this.btnAddFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFeed.Name = "btnAddFeed";
            this.btnAddFeed.Size = new System.Drawing.Size(85, 25);
            this.btnAddFeed.TabIndex = 4;
            this.btnAddFeed.Text = "Add feed list";
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
            this.txtBoxUrl.Text = "http://feeds.noodle.mx/TheAudacitytoPodcast-mp3";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(19, 33);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(35, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "URL :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblNameOfFeed);
            this.groupBox1.Controls.Add(this.txtBoxNameOfFeed);
            this.groupBox1.Controls.Add(this.btnAddFeed);
            this.groupBox1.Controls.Add(this.txtBoxUrl);
            this.groupBox1.Controls.Add(this.lblUrl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 566);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // tabCtrlFeeds
            // 
            this.tabCtrlFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlFeeds.Location = new System.Drawing.Point(220, 60);
            this.tabCtrlFeeds.Name = "tabCtrlFeeds";
            this.tabCtrlFeeds.SelectedIndex = 0;
            this.tabCtrlFeeds.Size = new System.Drawing.Size(651, 566);
            this.tabCtrlFeeds.TabIndex = 17;
            // 
            // txtBoxNameOfFeed
            // 
            this.txtBoxNameOfFeed.Location = new System.Drawing.Point(68, 67);
            this.txtBoxNameOfFeed.Name = "txtBoxNameOfFeed";
            this.txtBoxNameOfFeed.Size = new System.Drawing.Size(117, 20);
            this.txtBoxNameOfFeed.TabIndex = 5;
            // 
            // lblNameOfFeed
            // 
            this.lblNameOfFeed.AutoSize = true;
            this.lblNameOfFeed.Location = new System.Drawing.Point(13, 70);
            this.lblNameOfFeed.Name = "lblNameOfFeed";
            this.lblNameOfFeed.Size = new System.Drawing.Size(41, 13);
            this.lblNameOfFeed.TabIndex = 6;
            this.lblNameOfFeed.Text = "Name :";
            // 
            // grpBoxCategory
            // 
            this.grpBoxCategory.Controls.Add(this.button1);
            this.grpBoxCategory.Controls.Add(this.listBoxCategories);
            this.grpBoxCategory.Controls.Add(this.lblCategories);
            this.grpBoxCategory.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpBoxCategory.Location = new System.Drawing.Point(671, 60);
            this.grpBoxCategory.Name = "grpBoxCategory";
            this.grpBoxCategory.Size = new System.Drawing.Size(200, 566);
            this.grpBoxCategory.TabIndex = 19;
            this.grpBoxCategory.TabStop = false;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(82, 16);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(57, 13);
            this.lblCategories.TabIndex = 0;
            this.lblCategories.Text = "Categories";
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(3, 39);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(194, 524);
            this.listBoxCategories.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove category";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Category :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 646);
            this.Controls.Add(this.grpBoxCategory);
            this.Controls.Add(this.tabCtrlFeeds);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Podcast - collector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxCategory.ResumeLayout(false);
            this.grpBoxCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddFeed;
        private System.Windows.Forms.TextBox txtBoxUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabCtrlFeeds;
        private System.Windows.Forms.Label lblNameOfFeed;
        private System.Windows.Forms.TextBox txtBoxNameOfFeed;
        private System.Windows.Forms.GroupBox grpBoxCategory;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

