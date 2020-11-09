using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace FirstFantasy.Classes.Equipment
{
    public class Armor
    {

        int resistance;
        int agility;
        int health;

        public int Resistance { get => resistance; set => resistance = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Health { get => health; set => health = value; }

        public string Armordescription()
        {
            return $"Resistance: {resistance} Agility:  {agility} Health: {health} ";
        }

        public static implicit operator Armor(ComboBox v)
        {
            throw new NotImplementedException();
        }
    }
}
