using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningRobotsDatabase
{
    [Serializable]
    class Robot
    {
        string model;
        string manufacturer;
        string price;
        string webpage;
        string photoLocation;

        [System.ComponentModel.DisplayName("Model")]
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        [System.ComponentModel.DisplayName("Producent")]
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        [System.ComponentModel.DisplayName("Cena")]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Webpage
        {
            get { return webpage; }
            set { webpage = value; }
        }

        public string PhotoLocation
        {
            get { return photoLocation; }
            set { photoLocation = value; }
        }
    }
}
