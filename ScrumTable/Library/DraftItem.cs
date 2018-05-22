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
    //MetroTitle nesnesinden miras alıyoruz bu sınıfla 
    class DraftItem : MetroTile
    {
        public Drafts Draft { get; set; }


        public DraftItem()
        {

        }

        public DraftItem(Drafts draft)
        {
            this.Draft = draft;
            this.Text = Draft.Content;
            this.Width = 200;
            this.Height = 60;
            this.Visible = true;
        }

    }
}
