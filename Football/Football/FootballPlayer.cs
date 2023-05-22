using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    internal abstract class FootballPlayer : Person
    {
        private int number;
        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        protected FootballPlayer(string name, int number, int age, double height) : base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
