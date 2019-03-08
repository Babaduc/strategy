using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Bow:EquippedWeapon
    {
        
        protected string type="Дальний бой";
        protected string name="Лук";
        protected int mindamage = 10;
        protected int maxdamage  = 20;

        public int GetDmg()
        {
            Random rand = new Random();
            return rand.Next(mindamage,maxdamage);
        }
        public string GetName()
        {
            return name;
        }
    }
}
