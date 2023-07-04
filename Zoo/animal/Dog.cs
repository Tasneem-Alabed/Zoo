using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Interface;

namespace Zoo
{
    public class Dog:Mammals , Imigrate

    {
        Mammals Mammal { get; set; }
        Mammals Mammals { get; set; }

        public Dog() { 
        
        }
        public Dog(int Age, String Name, String Gender)
        {
            this.Age = Age;
            this.Name = Name;
            this.gender = Gender;
        }
        public bool IMigrate()
        {
           
            return true;
        }
    }
}
