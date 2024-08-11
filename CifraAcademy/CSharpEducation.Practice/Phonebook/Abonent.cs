using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Abonent
    {
        private string name;
        private string numberPhone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }
            set 
            {
                numberPhone = value;
            }
        }
    }
}
