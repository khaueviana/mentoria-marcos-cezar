using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            /*
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }*/
            /*
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach  (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }*/

            /*Dictionary<string, Car> myDic = new Dictionary<string, Car>();

            myDic.Add(car1.VIN, car1);
            myDic.Add(car2.VIN, car2);


            Console.WriteLine(myDic["A2"].Make);*/

            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "D4" };


            List<Car> myList = new List<Car>()
            {
                new Car {Make = "Oldsmobile", Model = "Cutlass Supreme", VIN = "ES"},
                new Car {Make = "Nissa",Model = "Altima", VIN = "F6"}
            };

            Console.WriteLine(myList[1].Model);


            Console.Read();


        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }


}
