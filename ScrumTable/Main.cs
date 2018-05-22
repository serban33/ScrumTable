using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using ScrumTable.Models;
using ScrumTable.Library;

namespace ScrumTable
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        /*
         * Bu projede database işlemleri için entity framework code-first yaklaşımı kullanılmıştır
         */
        private Context db = new Context();

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadStoryPanel();
        }

        private void addDraft(object sender, EventArgs e)
        {
            Mb item = sender as Mb;
            MetroFramework.Forms.MetroForm form = new ScrumTable.Forms.AddDraft(item.StoryId);
            form.Show();
            PanelDone.Controls.Clear();
            PanelInProgress.Controls.Clear();
            PanelNotStarted.Controls.Clear();
        }

        private void deleteStory(object sender, EventArgs e)
        {
            Mb item = sender as Mb;
            var confirmResult = MessageBox.Show("Are you sure to delete this item ?" , "Confirm Delete!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                using (Context db = new Context())
                {
                    foreach(Drafts removed in db.Drafts.Where(x => x.StoryId == item.StoryId).ToList())
                    {
                        db.Drafts.Remove(removed);
                    }
                    var removedStory = db.Story.Where(x => x.Id == item.StoryId).FirstOrDefault();
                    db.Story.Remove(removedStory);
                    try
                    {
                        db.SaveChanges();
                        MetroMessageBox.Show(this, "Deletion completed successfully!");
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Transaction not completed! Please try again!.");
                    }

                }
            }
        }

        private void loadStoryPanel()
        {
            PanelStoryies.Controls.Clear();
            PanelStoryies.Refresh();

            int top = PanelStoryies.Top;

            foreach (Story item in db.Story.ToList())
            {
                var storyItem = new StoryObject(item, PanelStoryies);
                storyItem.NSPanel = PanelNotStarted;
                storyItem.IPPanel = PanelInProgress;
                storyItem.DPanel = PanelDone;
                storyItem.Top = top;

                Mb btn = new Mb();
                btn.StoryId = item.Id;
                btn.Text = "Add..";
                btn.Visible = true;
                btn.Top = top;
                btn.Left = storyItem.Right;
                btn.Width = 60;
                btn.Height = 50;
                btn.Click += new EventHandler(addDraft);
                PanelStoryies.Controls.Add(btn);

                Mb btnDelete = new Mb();
                btnDelete.StoryId = item.Id;
                btnDelete.Text = "Delete..";
                btnDelete.Visible = true;
                btnDelete.Top = top + 50;
                btnDelete.Left = storyItem.Right;
                btnDelete.Width = 60;
                btnDelete.Height = 50;
                btnDelete.Click += new EventHandler(deleteStory);
                PanelStoryies.Controls.Add(btnDelete);

                top += 110;
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Forms.AddStory form = new Forms.AddStory();
            form.FormClosed += new FormClosedEventHandler(addStoryClosing);
            form.Show();
        }

        private void addStoryClosing(object sender, FormClosedEventArgs e)
        {
            PanelNotStarted.Controls.Clear();
            PanelNotStarted.Refresh();
            PanelInProgress.Controls.Clear();
            PanelInProgress.Refresh();
            PanelDone.Controls.Clear();
            PanelDone.Refresh();

            loadStoryPanel();
        }
    }
}
