using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CleaningRobotsDatabase
{
    public partial class FormMainWindow : Form
    {
        public FormMainWindow()
        {
            InitializeComponent();
            //wczytywanie bazy danych przy starcie programu
            if (databaseDirectory!="")
            {
                ReadFromFile();
            }
        }
        
        List<Robot> RobotList = new List<Robot>();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        string databaseDirectory = "..\\..\\db.bin"; //przypisanie konkretnej bazy danych do zmiennej powoduje wczytanie jej przy starcie programu

        //funkcja wczytująca w pola textBox odpowiednie wartości w celu łatwiejszej edycji
        private void dataGridViewRobots_MouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxModel.Text = RobotList[dataGridViewRobots.SelectedRows[0].Index].Model;
            textBoxManufacturer.Text = RobotList[dataGridViewRobots.SelectedRows[0].Index].Manufacturer;
            textBoxPrice.Text = RobotList[dataGridViewRobots.SelectedRows[0].Index].Price;
            textBoxWebPage.Text = RobotList[dataGridViewRobots.SelectedRows[0].Index].Webpage;
            textBoxPhotoLocation.Text = RobotList[dataGridViewRobots.SelectedRows[0].Index].PhotoLocation;
            pictureBoxRobotImage.ImageLocation = RobotList[dataGridViewRobots.SelectedRows[0].Index].PhotoLocation;
        }

        #region Przyciski
        private void buttonAdd_Click(object sender, EventArgs e)
        {   
            Robot robot = new Robot();
            GetRobotData(robot);
            RobotList.Add(robot);
            RefreshDataGridViewRobots();
            TextBoxClear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            RobotList[dataGridViewRobots.SelectedRows[0].Index].Model = textBoxModel.Text;
            RobotList[dataGridViewRobots.SelectedRows[0].Index].Manufacturer = textBoxManufacturer.Text;
            RobotList[dataGridViewRobots.SelectedRows[0].Index].Price = textBoxPrice.Text;
            RobotList[dataGridViewRobots.SelectedRows[0].Index].Webpage = textBoxWebPage.Text;
            RobotList[dataGridViewRobots.SelectedRows[0].Index].PhotoLocation = textBoxPhotoLocation.Text;
            RefreshDataGridViewRobots();
            TextBoxClear();
        }
    
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (RobotList.Count > 0)
            {
                RobotList.RemoveAt(dataGridViewRobots.SelectedRows[0].Index);
                RefreshDataGridViewRobots();
            }
        }

        private void buttonOpenWebside_Click(object sender, EventArgs e)
        {
            if (RobotList.Count >0)
            {
                if (RobotList[dataGridViewRobots.SelectedRows[0].Index].Webpage!=null)
                {
                    //otwieranie nowej karty w domyślnej przeglądarce ze stroną www danego robota
                    System.Diagnostics.Process.Start(RobotList[dataGridViewRobots.SelectedRows[0].Index].Webpage);
                }
            }
        }

        private void buttonAddPhoto_Click(object sender, EventArgs e)
        {
            ImageLoader imageLoader = new ImageLoader();
            imageLoader.ShowDialog();
            textBoxPhotoLocation.Text = imageLoader.GetLink;
        }
        
        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "BIN|*.bin"; // ustawienie filtrowania rozszerzeń plików
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "db");
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                databaseDirectory = openFileDialog.FileName;
                ReadFromFile();
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "BIN|*.bin"; // ustawienie filtrowania rozszerzeń plików
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "db");
            saveFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            if (saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                databaseDirectory = saveFileDialog.FileName;
                WriteToFile();
            }    
        }

        private void buttonClearWebPage_Click(object sender, EventArgs e)
        {
            textBoxWebPage.Clear();
        }

        private void buttonClearManufacturer_Click(object sender, EventArgs e)
        {
            textBoxManufacturer.Clear();
        }

        private void buttonClearPrice_Click(object sender, EventArgs e)
        {
            textBoxPrice.Clear();
        }

        private void buttonClearModel_Click(object sender, EventArgs e)
        {
            textBoxModel.Clear();
        }
        #endregion

        #region Funkcje
        private void GetRobotData(Robot robot)
        {
            robot.Model = textBoxModel.Text;
            robot.Manufacturer = textBoxManufacturer.Text;
            robot.Price = textBoxPrice.Text;
            robot.Webpage = textBoxWebPage.Text;
            robot.PhotoLocation = textBoxPhotoLocation.Text;
        }

        private void RefreshDataGridViewRobots()
        {
            dataGridViewRobots.DataSource = null;
            dataGridViewRobots.DataSource = RobotList;
            // ustawianie domyślnych długości kolumn i wyłączenie wyświetlania kolumny "strona www" oraz "zdjecie"
            dataGridViewRobots.Columns[3].Visible = false;
            dataGridViewRobots.Columns[4].Visible = false;
            dataGridViewRobots.Columns["Model"].Width = 285;
            dataGridViewRobots.Columns["Manufacturer"].Width = 285;
            dataGridViewRobots.Columns["Price"].Width = 105;
            dataGridViewRobots.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //zawsze zaznaczany jest cały wiersz zamiast pojedynczych komórek
        }

        private void TextBoxClear()
        {
            textBoxModel.Clear();
            textBoxManufacturer.Clear();
            textBoxPrice.Clear();
            textBoxWebPage.Clear();
        }

        private void WriteToFile()
        {
            //serializacja do binary
            using (Stream stream = File.Open(databaseDirectory, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                bformatter.Serialize(stream, RobotList);
            }
        }

        private void ReadFromFile()
        {
            //deserializacja
            using (Stream stream = File.Open(databaseDirectory, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                RobotList = (List<Robot>)bformatter.Deserialize(stream);
                RefreshDataGridViewRobots();
            }
        }

        #endregion
    }
}
