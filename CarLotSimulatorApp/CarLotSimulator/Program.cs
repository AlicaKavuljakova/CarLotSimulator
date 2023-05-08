using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO


            var carlot= new Carlot();
           
            //Now that the Car class is created we can instanciate 3 new cars
           
            var car2 = new Car();
            
            //Set the properties for each of the cars
           car2.Make = "Chevy";
            car2.Model = "Malibu";
            car2.Year = 2010;
            car2.EngineNoise = "weeeeum";
            car2.HonkNoise = "beep beep";
            car2.IsDriveable = true;
            carlot.Cars.Add(car2);

            var davesCar = new Car()
            {
                Year = 2013,
                Model = "ForTwo",
                Make = "Smart",
                EngineNoise="Wrrom caput",
                HonkNoise="beep-beep",
                IsDriveable=!true
            };
            carlot.Cars.Add(davesCar);

            var aliCar = new Car(2013,"Toyota","Corolla","purrrr","beep",true);
            carlot.Cars.Add(aliCar);
            carlot.Cars.Add(new Car(2011,"Nissan","Sentra","wrrrrrom","pitatata",false));
       
            //Call each of the methods for each car
            Console.WriteLine("Engine noises:");
            car2.MakeEngineNoise();
            aliCar.MakeEngineNoise();
            davesCar.MakeEngineNoise();
            Console.WriteLine("Honk noises:");
            car2.MakeHonkNoise(car2.HonkNoise);
            aliCar.MakeHonkNoise(aliCar.HonkNoise);
            davesCar.MakeHonkNoise(davesCar.HonkNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("These cars are in carlot:");
            foreach (var item in carlot.Cars)
            {
                Console.WriteLine($"Year:{item.Year}  Make: {item.Make}  Model: {item.Model}");
            }
        }
    }
}
