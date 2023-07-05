using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Pinguin : Reproduces_with_eggs
    {
        Reproduces_with_eggs reproduces_With_Eggs { get; set; }
        Reproduces_with_eggs reproduces_With_Eggs1 { get; set; }

        public Pinguin() { }
    }
}
