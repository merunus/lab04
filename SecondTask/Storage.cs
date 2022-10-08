using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Storage
    {
        List<ColdWeapon> weapons;

        public Storage(ColdWeapon weapon1, ColdWeapon weapon2) : this(weapon1, weapon2, null)
        {

        }

        public Storage(ColdWeapon weapon1, ColdWeapon weapon2, ColdWeapon weapon3)
        {
            weapons = new List<ColdWeapon>();
            weapons.Add(weapon1);
            weapons.Add(weapon2);

            if (weapon3 != null)
            weapons.Add(weapon3);
        }

        public void ShowTree()
        {
            foreach (ColdWeapon weapon in weapons)
            {           
                weapon.ShowMethods();
            }
        }
    }
}
