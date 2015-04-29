using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    class Program
    {
        static void Main(string[] args)
        {
            WhiteGoodsCatalog goods = new WhiteGoodsCatalog();
            goods.Add(new VacuumCleaner()
            {
                NameProduction = "LG",
                ClassEnergy = ClassEnergy.B,
                Price = 900000,
                DateProduction = new DateTime(2000, 1, 3),
                Power = 2000,
                TypeCleaner = TypeCleaner.dry,
                TypeDustCollector = TypeDustCollector.bag
            }
            );
            goods.Add(new Refrigerator()
            {
                NameProduction = "Atlant",
                ClassEnergy = ClassEnergy.A,
                Price = 2000000,
                DateProduction = new DateTime(1999, 10, 3),
                TypeControl = TypeControl.mechanical,
                TypeDesign = TypeDesign.onedoor
                
            }
                );
            goods.Add(new TV()
            {
                NameProduction = "Samsung",
                ClassEnergy = ClassEnergy.B,
                Price = 7000000,
                DateProduction = new DateTime(2010, 10, 3),
                ScreenSize = 82,
                ScreenType = ScreenType.LCD
            }
                );
            goods.Add(new Washer()
            {
                NameProduction = "Bosh",
                ClassEnergy = ClassEnergy.A,
                Price = 1000000,
                DateProduction = new DateTime(2012, 9, 3),
                MaxLoad = 5,
                MaxSpinSpeed = 1000,
                TypeLoad = TypeLoad.vertical,
                TypeWasher = TypeWasher.automatic
                
            }
                );
            
            Console.WriteLine("Сортируем по дате:");
            goods.SortByCreationDate();
            foreach (var i in goods)
            {
                Console.WriteLine("{0}, {1},{2}",i.ToString(), i.NameProduction, i.DateProduction);
            }
            Console.WriteLine();
            Console.WriteLine("Сортируем по классу энергопотребления:");
            goods.SortByClassEnergy();
            foreach (var i in goods)
            {
                Console.WriteLine("{0}, {1}, {2}", i.ToString(), i.NameProduction, i.ClassEnergy);
            }
            Console.WriteLine();
            Console.WriteLine("Сортируем по цене:");
            goods.SortByPrice();
            foreach (var i in goods)
            {
                Console.WriteLine("{0}, {1}, {2}", i.ToString(), i.NameProduction, i.Price);
            }
            Console.WriteLine();
            DateTime startdate = new DateTime(1999, 01, 01);
            DateTime enddate = new DateTime(2010, 12, 01);
            Console.WriteLine("Прозведены с {0} по {1}",startdate,enddate);
            foreach (var i in goods.GetWhiteGoods(startdate, enddate))
            {
                Console.WriteLine("{0}, {1}, {2}", i.ToString(), i.NameProduction, i.DateProduction);
            }
            Console.WriteLine();
            double startprice = 1000000;
            double endprice = 2000000;
            Console.WriteLine("Цена от {0} до {1}", startprice, endprice);
            foreach (var i in goods.GetWhiteGoods(startprice, endprice))
            {
                Console.WriteLine("{0}, {1}, {2}", i.ToString(), i.NameProduction, i.Price);
            }
            Console.ReadKey();
        }
    }
}
