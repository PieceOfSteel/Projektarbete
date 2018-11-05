namespace Projekt_C
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameOfFeed = new System.Windows.Forms.Label();
            this.txtNameOfFeed = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Add feed";
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(320, 187);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(117, 20);
            this.txtFrequency.TabIndex = 30;
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(201, 187);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 29;
            this.lblFrequency.Text = "Frequency";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(320, 144);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(117, 21);
            this.comboBoxCategories.TabIndex = 28;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(201, 147);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 27;
            this.lblCategory.Text = "Category :";
            // 
            // lblNameOfFeed
            // 
            this.lblNameOfFeed.AutoSize = true;
            this.lblNameOfFeed.Location = new System.Drawing.Point(201, 108);
            this.lblNameOfFeed.Name = "lblNameOfFeed";
            this.lblNameOfFeed.Size = new System.Drawing.Size(38, 13);
            this.lblNameOfFeed.TabIndex = 26;
            this.lblNameOfFeed.Text = "Name ";
            // 
            // txtNameOfFeed
            // 
            this.txtNameOfFeed.Location = new System.Drawing.Point(320, 108);
            this.txtNameOfFeed.Name = "txtNameOfFeed";
            this.txtNameOfFeed.Size = new System.Drawing.Size(117, 20);
            this.txtNameOfFeed.TabIndex = 25;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(320, 68);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(117, 20);
            this.txtUrl.TabIndex = 23;
            this.txtUrl.Text = "http://feeds.noodle.mx/TheAudacitytoPodcast-mp3";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(201, 71);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 24;
            this.lblUrl.Text = "URL ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.comboBoxCategories);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNameOfFeed);
            this.Controls.Add(this.txtNameOfFeed);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "Form2";
            this.Text = "UIAddFeed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNameOfFeed;
        private System.Windows.Forms.TextBox txtNameOfFeed;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
    }
}