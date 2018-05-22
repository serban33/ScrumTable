using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Controls;
using ScrumTable.Models;
using System.Windows.Forms;

namespace ScrumTable.Library
{
    class StoryObject : MetroTile
    {
        public Story Story { get; set; } // işlem yapılan story nesnesi 
        public MetroPanel SPanel { get; set; } // story panel   
        public MetroPanel NSPanel { get; set; } // Notstarted panel
        public MetroPanel IPPanel { get; set; } // in progress panel    
        public MetroPanel DPanel { get; set; } // Done panel

        public StoryObject(Story story, MetroPanel panel)
        {
            this.Story = story; // gönderdiğimiz story nesnesini sınıfımızda işlem yapacağımız nesneye aktarıyoruz
            this.SPanel = panel;// üzerindeçalıştığımız panel
            this.Visible = true; // görünürlük true yapıyoruz
            this.Style = MetroColorStyle.Orange; //title nesnemizin rengini veriyoruz
            this.Width = 100;//genişlik
            this.Height = 100;//yükseklik
            this.Text = story.Content; //title itemimizin üzerinde yazan metni set ediyoruz
            this.Click += new EventHandler(storyClick);// bu objeye tıklanınca hangi metodun tetikleneceğini bekirtiyoruz
            SPanel.Controls.Add(this);//panelimize kontrolü(title object) ekliyoruz
        }


        /// <summary>
        /// story nenemize tıklanınca çalışacak metoddur burada draftlar(görevler) statusa göre ilgili panele eklenir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storyClick(object sender, EventArgs e)
        {
            this.clearItems();
            int nstop = NSPanel.Top;
            int iptop = IPPanel.Top;
            int dtop = DPanel.Top;

            foreach (Drafts item in new Context().Drafts.Where(x => x.StoryId == this.Story.Id).ToList()) // bu story e ait görevler listesi veritabanından çekiliyor
            {
                DraftItem pItem = new DraftItem(item); // görevler nesnemizi türetip set ediyoruz
                pItem.Click += new EventHandler(draftClick); // görev nesnesine tıklantığında çalışacak olan metodumuzu set ediyoruz

                /*
                 * görevlerimiz statusa göre ilgili panele yerleştiriliyor
                 */
                if (item.Status == 0)
                {
                    pItem.Top = nstop;// görev nesnemizin yerleşimini yapıyoruz 
                    nstop += 70;// bir sonraki görev nesnesinin yeri için hazırlık
                    pItem.Style = MetroColorStyle.Red;//görev nesnemizin rengini belirtiyoruz
                    NSPanel.Controls.Add(pItem);//ilgili panele ekliyoruz
                }
                else if (item.Status == 1)
                {
                    pItem.Top = iptop;
                    iptop += 70;
                    pItem.Style = MetroColorStyle.Green;
                    IPPanel.Controls.Add(pItem);
                }
                else if (item.Status == 2)
                {
                    pItem.Top = dtop;
                    dtop += 70;
                    pItem.Style = MetroColorStyle.Teal;
                    DPanel.Controls.Add(pItem);
                }
            }

        }

        /// <summary>
        /// Görevler panelindeki önceki nesneleri sildiğimiz metod
        /// </summary>
        private void clearItems()
        {
            NSPanel.Controls.Clear();
            NSPanel.Refresh();
            IPPanel.Controls.Clear();
            IPPanel.Refresh();
            DPanel.Controls.Clear();
            DPanel.Refresh();
        }

        /// <summary>
        /// görev(draft) nesnesine tıklandığında çalışacak metod
        /// bu metod da görev düzenleme formu açılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void draftClick(object sender, EventArgs e)
        {
            MetroFramework.Forms.MetroForm form = new Forms.EditDraft((sender as DraftItem).Draft); // görev düzenleme formunu türetip işlem yapılangörevi fora gönderiyoruz
            form.Show();//formu gösteriyoruz
        }

    }
}
