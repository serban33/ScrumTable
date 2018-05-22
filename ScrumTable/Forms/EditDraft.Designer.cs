namespace ScrumTable.Forms
{
    partial class EditDraft
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbx_status = new MetroFramework.Controls.MetroComboBox();
            this.txt_content = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_save);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.cbx_status);
            this.metroPanel1.Controls.Add(this.txt_content);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(411, 170);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(238, 115);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(127, 28);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "Status";
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.ItemHeight = 23;
            this.cbx_status.Location = new System.Drawing.Point(71, 80);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(294, 29);
            this.cbx_status.TabIndex = 12;
            this.cbx_status.UseSelectable = true;
            // 
            // txt_content
            // 
            // 
            // 
            // 
            this.txt_content.CustomButton.Image = null;
            this.txt_content.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.txt_content.CustomButton.Name = "";
            this.txt_content.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_content.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_content.CustomButton.TabIndex = 1;
            this.txt_content.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_content.CustomButton.UseSelectable = true;
            this.txt_content.CustomButton.Visible = false;
            this.txt_content.Lines = new string[0];
            this.txt_content.Location = new System.Drawing.Point(71, 51);
            this.txt_content.MaxLength = 32767;
            this.txt_content.Name = "txt_content";
            this.txt_content.PasswordChar = '\0';
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_content.SelectedText = "";
            this.txt_content.SelectionLength = 0;
            this.txt_content.SelectionStart = 0;
            this.txt_content.ShortcutsEnabled = true;
            this.txt_content.Size = new System.Drawing.Size(294, 23);
            this.txt_content.TabIndex = 11;
            this.txt_content.UseSelectable = true;
            this.txt_content.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_content.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Content";
            // 
            // EditDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 254);
            this.Controls.Add(this.metroPanel1);
            this.Name = "EditDraft";
            this.Text = "EditDraft";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbx_status;
        private MetroFramework.Controls.MetroTextBox txt_content;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}