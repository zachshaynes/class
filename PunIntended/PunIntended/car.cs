using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunIntended
{
    class car
    {
        //properties
        string make;
        string model;
        double milestraveled;
        double mpg;
        double tanksize;
        double gallonsofgas;

        //constructor
        public  car()
        {
            make = "Ford";
            model = "Mustang";
            milestraveled = 0;
            mpg = 24;
            tanksize = 12;
            gallonsofgas = tanksize;
        }
        
       public car(string Make, string Model, double MPG,double Tanksize)
        {
            Make = make;
            Model = model;
            MPG = mpg;
            gallonsofgas = Tanksize;
        }


    }

}
