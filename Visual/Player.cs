using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public Player(string Name)
        {
            this.Name = Name;
            this.Points = 0;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Name, Points);
        }
    }
}
