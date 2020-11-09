using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    class Wand : Weapon
    {
        public Wand()
        {
            Damage = 5; //La magia esta en el mago no en la varita
        }
    }
}
