using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Bird : Reproduces_with_eggs , Ipreys_on
    {
        Reproduces_with_eggs reproduces_With_Eggs { get; set; }
        Reproduces_with_eggs reproduces_With_Eggs1 { get; set; }

        public Bird()
        {

        }
        public Bird(int Age, String Name, String Gender)
        {
            this.Age = Age;
            this.Name = Name;
            this.gender = Gender;
        }

        public bool IPreys_on()
        {
            return true;
        }
    }
}
