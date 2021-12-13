using System.Collections.Generic;
using System.Net.Http;
using System;

namespace ConsumirParcialComputo3
{
    class Program
    {
        private static int ver_menu;

        private static int opcion_menu; 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            do{
                System.Console.WriteLine("Menu Principal para consumir la API Car UGB");
                System.Console.WriteLine("\n");

            System.Console.WriteLine("1- Obtener Lista de Carros.");
            System.Console.WriteLine("2-Obtener Lista de Marcas");

            opcion_menu = Convert.ToInt32(Console.ReadLine());
            
            switch(opcion_menu)
            {
                case 1:
                GetAllCars();
                break;
                case 2:
                GetAllBrands();
                break;
            }
            
                System.Console.WriteLine("¿Desea volver a ver el Menu?");
                System.Console.WriteLine("1. Si, volver a verlo.");
                System.Console.WriteLine("2. No, Salir.");
                ver_menu = Convert.ToInt32(Console.ReadLine());
            }while(ver_menu==1);

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

        static void GetAllBrands()
        {
            ClientAPI client = new ClientAPI();

            HttpResponseMessage httpResponseMessage = client.Find("Brand").Result;
            List<Brand> brands = httpResponseMessage.Content.ReadAsAsync<List<Brand>>().Result;
            Console.WriteLine("Brands");

            foreach(Brand brand in brands)
            {
                System.Console.WriteLine("ID Brand: " + brand.idBrand);
                System.Console.WriteLine("Name Brand: " + brand.nameBrand);
            }
        }
    }
}
