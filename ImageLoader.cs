using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleaningRobotsDatabase
{
    public partial class ImageLoader : Form
    {
        public ImageLoader()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        string link; //zmienna przechowująca link lub ścieżkę dostępu do zdjęcia
        public string GetLink
        {
            get { return link; }
            set { link = value; }
            
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            //kliknięcie przycisku buttonDone powoduje przypisanie stringu z linkiem do zmiennej link oraz ukrycie okna ImageLoader
            GetLink = textBoxLinkToImage.Text;
            this.Hide();
        }

        private void buttonImageAdd_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBoxLinkToImage.Text = ofd.FileName;
            }
        }
    }
}
