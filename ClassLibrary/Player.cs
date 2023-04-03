using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Player
    {
        public string ID { get; set; }
        public string PlayerName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Health { get; set; }
        public Weapon Weapon { get; set; }
        public int Section { get; set; }
        public int Stage { get; set; }
        public int Step { get; set; }
    }
}
