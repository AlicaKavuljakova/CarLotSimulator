using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        //Create a seperate class file called Car
       public Car() //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        {
            Carlot.NumberOfCars++;
        }
        public Car(int year,string make,string model,string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDrivable;
            Carlot.NumberOfCars++;
            
        }
           
        
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model{ get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
    
        public void PritnDetails()
        {
            Console.WriteLine($"This car's details are: year:{Year}, make : {Make}, model: {Model}");
            if(IsDriveable)
            { Console.WriteLine("Is drivable"); }
            else { Console.WriteLine("not drivable"); }
        }
       
        public void MakeEngineNoise()
        {
    
            Console.WriteLine(  EngineNoise);
        }
        public void MakeHonkNoise(string honkNoise)
        {
       
            Console.WriteLine(  honkNoise);
        }
        //The methods should take one string parameter: the respective noise property

    }
}
