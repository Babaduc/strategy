using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Sword:EquippedWeapon
    {
        protected string type = "Ближний бой";
        protected string name = "Меч";
        protected int mindamage = 100;
        protected int maxdamage = 150;

        public int GetDmg()
        {
            Random rand = new Random();
            return rand.Next(mindamage, maxdamage);

        }

        public string GetName()
        {
            return name;
        }
    }
}
