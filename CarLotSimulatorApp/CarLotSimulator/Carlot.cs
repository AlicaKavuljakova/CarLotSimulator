﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Carlot
    {
        public Carlot()
        { 

        } 
        
        public List<Car> Cars { get; set; } = new List<Car>();// same as => public List<Car> Cars= new List<Car> {};
        public static int NumberOfCars;
    }
}
