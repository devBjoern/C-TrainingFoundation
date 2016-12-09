using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChanged
{
    class Person
    {

        public event EventHandler PropertyChanged;

        private int id;

        public int ID
        {
            get { return id; }
            set {
                OnPorpertyChangedEventHandler();
                id = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set {
                OnPorpertyChangedEventHandler();
                name = value; }
        }

        private void OnPorpertyChangedEventHandler()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new EventArgs());
            }
        }


    }
}
