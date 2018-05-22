namespace ScrumTable.Forms
{
    partial class AddStory
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
            this.PanelItems = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_name = new MetroFramework.Controls.MetroTextBox();
            this.txt_content = new MetroFramework.Controls.MetroTextBox();
            this.btn_save = new MetroFramework.Controls.MetroButton();
            this.PanelItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelItems
            // 
            this.PanelItems.Controls.Add(this.btn_save);
            this.PanelItems.Controls.Add(this.txt_content);
            this.PanelItems.Controls.Add(this.txt_name);
            this.PanelItems.Controls.Add(this.metroLabel2);
            this.PanelItems.Controls.Add(this.metroLabel1);
            this.PanelItems.HorizontalScrollbarBarColor = true;
            this.PanelItems.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelItems.HorizontalScrollbarSize = 10;
            this.PanelItems.Location = new System.Drawing.Point(23, 63);
            this.PanelItems.Name = "PanelItems";
            this.PanelItems.Size = new System.Drawing.Size(254, 214);
            this.PanelItems.TabIndex = 0;
            this.PanelItems.VerticalScrollbarBarColor = true;
            this.PanelItems.VerticalScrollbarHighlightOnWheel = false;
            this.PanelItems.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Story Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Content";
            // 
            // txt_name
            // 
            // 
            // 
            // 
            this.txt_name.CustomButton.Image = null;
            this.txt_name.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.txt_name.CustomButton.Name = "";
            this.txt_name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_name.CustomButton.TabIndex = 1;
            this.txt_name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_name.CustomButton.UseSelectable = true;
            this.txt_name.CustomButton.Visible = false;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(89, 19);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(148, 23);
            this.txt_name.TabIndex = 4;
            this.txt_name.UseSelectable = true;
            this.txt_name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_content
            // 
            // 
            // 
            // 
            this.txt_content.CustomButton.AutoSize = true;
            this.txt_content.CustomButton.Image = null;
            this.txt_content.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txt_content.CustomButton.Name = "";
            this.txt_content.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.txt_content.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_content.CustomButton.TabIndex = 1;
            this.txt_content.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_content.CustomButton.UseSelectable = true;
            this.txt_content.CustomButton.Visible = false;
            this.txt_content.Lines = new string[0];
            this.txt_content.Location = new System.Drawing.Point(89, 55);
            this.txt_content.MaxLength = 32767;
            this.txt_content.Multiline = true;
            this.txt_content.Name = "txt_content";
            this.txt_content.PasswordChar = '\0';
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_content.SelectedText = "";
            this.txt_content.SelectionLength = 0;
            this.txt_content.SelectionStart = 0;
            this.txt_content.ShortcutsEnabled = true;
            this.txt_content.Size = new System.Drawing.Size(148, 100);
            this.txt_content.TabIndex = 5;
            this.txt_content.UseSelectable = true;
            this.txt_content.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_content.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(89, 162);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseSelectable = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // AddStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.PanelItems);
            this.Name = "AddStory";
            this.Text = "AddStory";
            this.PanelItems.ResumeLayout(false);
            this.PanelItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelItems;
        private MetroFramework.Controls.MetroTextBox txt_name;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_save;
        private MetroFramework.Controls.MetroTextBox txt_content;
    }
}