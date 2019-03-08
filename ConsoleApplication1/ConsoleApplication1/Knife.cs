using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Knife : EquippedWeapon
    {
        protected string type = "Ближний бой";
        protected string name = "Нож";
        protected int mindamage = 5;
        protected int maxdamage = 10;

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
