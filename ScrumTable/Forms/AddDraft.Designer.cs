namespace ScrumTable.Forms
{
    partial class AddDraft
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_content = new MetroFramework.Controls.MetroTextBox();
            this.cbx_status = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Content";
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
            this.txt_content.Location = new System.Drawing.Point(84, 73);
            this.txt_content.MaxLength = 32767;
            this.txt_content.Name = "txt_content";
            this.txt_content.PasswordChar = '\0';
            this.txt_content.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_content.SelectedText = "";
            this.txt_content.SelectionLength = 0;
            this.txt_content.SelectionStart = 0;
            this.txt_content.ShortcutsEnabled = true;
            this.txt_content.Size = new System.Drawing.Size(294, 23);
            this.txt_content.TabIndex = 1;
            this.txt_content.UseSelectable = true;
            this.txt_content.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_content.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.ItemHeight = 23;
            this.cbx_status.Location = new System.Drawing.Point(84, 102);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(294, 29);
            this.cbx_status.TabIndex = 2;
            this.cbx_status.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 102);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Status";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(251, 137);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 28);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add !..";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 216);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddStory";
            this.Text = "Add new story";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_content;
        private MetroFramework.Controls.MetroComboBox cbx_status;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btn_add;
    }
}