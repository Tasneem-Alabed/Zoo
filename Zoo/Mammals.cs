using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public  abstract class Mammals : Animal
    {
        private String Gender;
        public int NumberOflegs(int numbre)
        {
            return numbre;
        }

        public virtual void JumbOrWalk(String s)
        {
           
                Console.WriteLine($"{Name} is {s}");
           

        }
        public virtual String gender
        {
            get
            {
                return Gender;
            }
            set
            {
                if (Gender.Equals("femail"))
                {
                    Gender = "femail";
                }
                else Gender = "Mail";
            }
        }

        public override string Name { get; set; }
        public override int Age { get; set; }

        public override void Eat()
        {
            Console.WriteLine($"{Name} eating");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} sleping");
        }

        public override void Sound()
        {
            Console.WriteLine($"{Name} makr sound");
        }

        public void IMigrate()
        {
            throw new NotImplementedException();
        }
    }
}
