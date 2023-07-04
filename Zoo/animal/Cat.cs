using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Cat : Mammals , Imigrate , Ipreys_on
    {
        Mammals Mammal { get; set; }
        Mammals Mammals { get; set; }
        public Cat() { 
        
        }
        public Cat(int Age, String Name, String Gender)
        {
            this.Age = Age;
            this.Name = Name;
            this.gender = Gender;
        }

        public bool IMigrate()
        {
            return true;
        }

        public bool IPreys_on()
        {
            return true;
        }
    }
}
