using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public class MilitaryUnit : Unit 
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public override int Health //Overwrites original Health given by Unit
        {
            get
            {
                return base.Health + XP;
            }
            set
            {
                base.Health = value;
            }
        }

        public override float Cost //Overwrites original Cost property
        {    
            get
            {
                return AttackPower + XP;
            }
        }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }
    }   
}