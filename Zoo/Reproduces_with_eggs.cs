using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public  abstract class Reproduces_with_eggs : Animal
    {
        private String Gender;
        public bool canFlay(bool answer)
        {
            return false;
        }
        public virtual bool canSwim(bool answer)
        {
            return answer;
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

        public void IPreys_on()
        {
            throw new NotImplementedException();
        }
    }
}
