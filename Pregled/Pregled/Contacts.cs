using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregled
{
    class Contacts
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public List<string> Messages;
        public Contacts(string name, string number)
        {
            Name = name;
            Number = number;
            Messages = new List<string>();
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Number);
        }
        public void newMessage(string m)
        {
            Messages.Add(m);
        }
        public string GetName()
        {
            return Name;
        }
    }
}
