using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    public class Club : ColdWeapon
    {
        public override int CalculateDamage()
        {
            return SwingAttack() + 15;
        }

        public int SwingAttack()
        {
            return damage + 25;
        }
    }
}
