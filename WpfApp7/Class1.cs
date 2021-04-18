using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp7
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        private string name;
        public string Name
        {
            get => name;
            set { Name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); }
        }



        private int date;
        public int Date
        {
            get => date;
            set { date = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date")); }
        }



        private string identification_number;
        public string Identification_number
        {
            get => identification_number;
            set { identification_number = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Identification Number")); }
        }





        public static Dictionary<string, Person> AllPersons = new Dictionary<string, Person>();



        public static void InitPersons()
        {
            AllPersons["Filip Kováč"] = new Person
            {
                Name = "Filip Kováč",
                Date = 2003,
                Identification_number = "xxxxx",
            };



            AllPersons["Pavel Novák"] = new Person
            {
                Name = "Pavel Novák",
                Date = 2000,
                Identification_number = "xxxxx",
            };



            AllPersons["Cornell"] = new Person
            {
                Name = "Luboš Soukup",
                Date = 1998,
                Identification_number = "xxxxx",
            };
        }
    }
}
}
