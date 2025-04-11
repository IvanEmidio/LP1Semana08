using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    public abstract class Unit 
    //Changed to abstract because we don't know what unity it will be.
    {
        private int movement;
        public virtual int Health { get; set; } 

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public abstract float Cost { get; } //Read-only abstract property
        
        //Shows how much the unity moved
        public void Move() => Console.WriteLine($"{movement}");
        
    }   
}