using System.Collections.Generic;
using System.Net.Http;
using System;

namespace ConsumirParcialComputo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GetAllCars();
            Console.ReadKey();
        }

        static void GetAllCars()
        {
            ClientAPI client = new ClientAPI();

            HttpResponseMessage httpResponseMessage = client.Find("Car").Result;
            List<Car> cars = httpResponseMessage.Content.ReadAsAsync<List<Car>>().Result;
            Console.WriteLine("Cars");

            foreach(Car car in cars)
            {
                System.Console.WriteLine("ID Car: " + car.idCar);
                System.Console.WriteLine("Model: " + car.modelCar);
                System.Console.WriteLine("Color: " + car.colorCar);
                System.Console.WriteLine("Year: " + car.yearCar);
                System.Console.WriteLine("Type: " + car.typeCar);
                System.Console.WriteLine("ID Brand: " + car.idBrand);
            }
        }
    }
}
