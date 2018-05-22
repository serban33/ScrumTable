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
using ScrumTable.Models;

namespace ScrumTable.Forms
{
    public partial class AddStory : MetroFramework.Forms.MetroForm
    {
        public AddStory()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Story item = new Story() { Name = txt_name.Text, Content = txt_content.Text };
                db.Story.Add(item);
                try
                {
                    db.SaveChanges();
                    MetroMessageBox.Show(this, "Operation complated!..");
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Operation failed!..");
                }
            }

            this.Close();
        }
    }
}
