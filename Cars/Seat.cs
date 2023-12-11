using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        string ICar.Model { get; set; }
        string ICar.Color { get ; set ;}
        string ICar.Start { get ; set ; }
        string ICar.Stop { get ; set ; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Break!";
        }
        public override string ToString()
        {
            return $"{this.color} Seat {this.model}\n" +
                $"{this.Start()}\n" +
<<<<<<< HEAD
                $"{this.Stop()}";
=======
                $"{this.Start()}";
>>>>>>> f66b935f539f115b5c3010a23eddcf78c8e9fe6c
        }


    }
}
