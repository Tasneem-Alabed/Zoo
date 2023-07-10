using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Rabbit :Mammals , Ipreys_on
    {
        Mammals Mammal { get; set; }
        Mammals Mammals { get; set; }

        public Rabbit()
        {

        }
        public Rabbit(int Age, String Name, String Gender)
        {
            this.Age = Age;
            this.Name = Name;
            this.gender = Gender;
        }
        public bool IPreys_on()
        {
            return false;
        }
    }
}
