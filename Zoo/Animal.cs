using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
   public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public  Animal(int Age , String Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public Animal()
        {
           
        }
        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Sound();
       
       



    }
}
