using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Chararacter : EquippedWeapon
    {
        protected string name= "Бабадук";
        protected EquippedWeapon weapon;
        protected void Hit()
        {
            Console.WriteLine("Я ударил оружием");
        }
       
    }
}
