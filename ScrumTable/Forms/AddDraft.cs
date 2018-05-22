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

namespace ScrumTable.Forms
{
    public partial class AddDraft : MetroFramework.Forms.MetroForm
    {
        private int StoryId { get; set; }

        public AddDraft()
        {
            InitializeComponent();
        }

        public AddDraft(int sId)
        {
            this.StoryId = sId;
            InitializeComponent();
            foreach (Item item in _get())
                cbx_status.Items.Add(item);
            cbx_status.DisplayMember = "Text";
            cbx_status.ValueMember = "Value";
        }

        private List<Item> _get()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Value = 0, Text = "Not Started" });
            items.Add(new Item() { Value = 1, Text = "In Proggress" });
            items.Add(new Item() { Value = 2, Text = "Done!" });
            return items;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ScrumTable.Models.Context db = new Models.Context();
            Models.Drafts item = new Models.Drafts() { StoryId = this.StoryId, Content = txt_content.Text, Status = Convert.ToInt32((cbx_status.SelectedItem as Item).Value) };
            db.Drafts.Add(item);
            db.SaveChanges();
            MetroMessageBox.Show(this,"Kayıt başarıyla oluşturuldu!..");
            this.Close();
        }
    }

    public class Item
    {
        public object Value { get; set; }
        public string Text { get; set; }
    }
}
