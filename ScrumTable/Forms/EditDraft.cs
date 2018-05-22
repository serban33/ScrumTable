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
    public partial class EditDraft : MetroFramework.Forms.MetroForm
    {
        private Drafts Draft { get; set; }

        public EditDraft()
        {
            InitializeComponent();
        }

        public EditDraft(Drafts draft)
        {
            this.Draft = draft;
            InitializeComponent();
            foreach (Item item in _get())
                cbx_status.Items.Add(item);
            cbx_status.DisplayMember = "Text";
            cbx_status.ValueMember = "Value";

            txt_content.Text = Draft.Content;
            cbx_status.SelectedIndex = Draft.Status;
            //cbx_status.SelectedValue = this.Draft.Status;
        }

        private List<Item> _get()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Value = 0, Text = "Not Started" });
            items.Add(new Item() { Value = 1, Text = "In Proggress" });
            items.Add(new Item() { Value = 2, Text = "Done!" });
            return items;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Context db = new Context();
            Drafts item = db.Drafts.Where(w => w.Id == Draft.Id).FirstOrDefault();
            item.Content = txt_content.Text;
            item.Status = Convert.ToInt32((cbx_status.SelectedItem as Item).Value);
            db.SaveChanges();
            this.Close();
        }
    }
}
