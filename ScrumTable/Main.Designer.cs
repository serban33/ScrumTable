namespace ScrumTable
{
    partial class Main
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
            this.PanelStoryies = new MetroFramework.Controls.MetroPanel();
            this.PanelDrafts = new MetroFramework.Controls.MetroPanel();
            this.PanelInProgress = new MetroFramework.Controls.MetroPanel();
            this.PanelDone = new MetroFramework.Controls.MetroPanel();
            this.PanelNotStarted = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.PanelDrafts.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelStoryies
            // 
            this.PanelStoryies.AutoScroll = true;
            this.PanelStoryies.HorizontalScrollbar = true;
            this.PanelStoryies.HorizontalScrollbarBarColor = true;
            this.PanelStoryies.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelStoryies.HorizontalScrollbarSize = 10;
            this.PanelStoryies.Location = new System.Drawing.Point(19, 63);
            this.PanelStoryies.Name = "PanelStoryies";
            this.PanelStoryies.Size = new System.Drawing.Size(200, 400);
            this.PanelStoryies.TabIndex = 0;
            this.PanelStoryies.VerticalScrollbar = true;
            this.PanelStoryies.VerticalScrollbarBarColor = true;
            this.PanelStoryies.VerticalScrollbarHighlightOnWheel = false;
            this.PanelStoryies.VerticalScrollbarSize = 10;
            // 
            // PanelDrafts
            // 
            this.PanelDrafts.Controls.Add(this.PanelInProgress);
            this.PanelDrafts.Controls.Add(this.PanelDone);
            this.PanelDrafts.Controls.Add(this.PanelNotStarted);
            this.PanelDrafts.HorizontalScrollbarBarColor = true;
            this.PanelDrafts.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDrafts.HorizontalScrollbarSize = 10;
            this.PanelDrafts.Location = new System.Drawing.Point(225, 90);
            this.PanelDrafts.Name = "PanelDrafts";
            this.PanelDrafts.Size = new System.Drawing.Size(622, 384);
            this.PanelDrafts.TabIndex = 2;
            this.PanelDrafts.VerticalScrollbarBarColor = true;
            this.PanelDrafts.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDrafts.VerticalScrollbarSize = 10;
            // 
            // PanelInProgress
            // 
            this.PanelInProgress.AutoScroll = true;
            this.PanelInProgress.HorizontalScrollbar = true;
            this.PanelInProgress.HorizontalScrollbarBarColor = true;
            this.PanelInProgress.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelInProgress.HorizontalScrollbarSize = 10;
            this.PanelInProgress.Location = new System.Drawing.Point(209, 6);
            this.PanelInProgress.Name = "PanelInProgress";
            this.PanelInProgress.Size = new System.Drawing.Size(200, 367);
            this.PanelInProgress.TabIndex = 2;
            this.PanelInProgress.VerticalScrollbar = true;
            this.PanelInProgress.VerticalScrollbarBarColor = true;
            this.PanelInProgress.VerticalScrollbarHighlightOnWheel = false;
            this.PanelInProgress.VerticalScrollbarSize = 10;
            // 
            // PanelDone
            // 
            this.PanelDone.AutoScroll = true;
            this.PanelDone.HorizontalScrollbar = true;
            this.PanelDone.HorizontalScrollbarBarColor = true;
            this.PanelDone.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelDone.HorizontalScrollbarSize = 10;
            this.PanelDone.Location = new System.Drawing.Point(415, 6);
            this.PanelDone.Name = "PanelDone";
            this.PanelDone.Size = new System.Drawing.Size(200, 367);
            this.PanelDone.TabIndex = 2;
            this.PanelDone.VerticalScrollbar = true;
            this.PanelDone.VerticalScrollbarBarColor = true;
            this.PanelDone.VerticalScrollbarHighlightOnWheel = false;
            this.PanelDone.VerticalScrollbarSize = 10;
            // 
            // PanelNotStarted
            // 
            this.PanelNotStarted.AutoScroll = true;
            this.PanelNotStarted.HorizontalScrollbar = true;
            this.PanelNotStarted.HorizontalScrollbarBarColor = true;
            this.PanelNotStarted.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelNotStarted.HorizontalScrollbarSize = 10;
            this.PanelNotStarted.Location = new System.Drawing.Point(3, 6);
            this.PanelNotStarted.Name = "PanelNotStarted";
            this.PanelNotStarted.Size = new System.Drawing.Size(200, 367);
            this.PanelNotStarted.TabIndex = 2;
            this.PanelNotStarted.VerticalScrollbar = true;
            this.PanelNotStarted.VerticalScrollbarBarColor = true;
            this.PanelNotStarted.VerticalScrollbarHighlightOnWheel = false;
            this.PanelNotStarted.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(19, 469);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(199, 42);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Add New Story";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(228, 42);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(200, 42);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Not Started!";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(640, 42);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(199, 42);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile2.TabIndex = 0;
            this.metroTile2.Text = "Done";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(434, 42);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(200, 42);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile3.TabIndex = 0;
            this.metroTile3.Text = "In Progress";
            this.metroTile3.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 527);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.PanelDrafts);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.PanelStoryies);
            this.Name = "Main";
            this.Text = "Scrum Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelDrafts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel PanelStoryies;
        private MetroFramework.Controls.MetroPanel PanelDrafts;
        private MetroFramework.Controls.MetroPanel PanelInProgress;
        private MetroFramework.Controls.MetroPanel PanelDone;
        private MetroFramework.Controls.MetroPanel PanelNotStarted;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

