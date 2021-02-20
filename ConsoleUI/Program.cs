using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

           
            CarManager manager = new CarManager(new EFCarDal());
            foreach (var thecar in manager.GetProductDetails())
            {
                Console.WriteLine("Detaylar getirildi");
                Console.WriteLine(thecar.CarId + " " + thecar.Descriptions + " " + thecar.DailyPrice+ " "+thecar.ColorName);
                
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            CarManager carManagerr = new CarManager(new EFCarDal());
            foreach (var car in carManagerr.GetCarsByColorId(2)) 
            {
                Console.WriteLine("2 numaralı renk id sıne sahip araba: {0}",car.Description);
            }

            ColorManager colorManager1 = new ColorManager(new EFColorDal());
           // colorManager1.Add(new Color {  ColorName = "Blue" });

            CarManager cm = new CarManager(new EFCarDal());
            //Car skoda = new Car { BrandId = 5, CarId = 8, ColorId = 2, DailyPrice = 2000, Description = "Skoda araba", ModelYear = 2015 };
            //cm.Add(skoda);
            cm.Update(new Car {  CarId=4, Description="bugatti araba"});

            foreach (var thecar in cm.GetCarsByBrandId(5))
            {
         //       Console.WriteLine(thecar.CarId+" "+thecar.Description+" "+thecar.DailyPrice);
           //     Console.WriteLine("Bugatti arabaya ait veriler başarıyla getirildi");
            }
            

            //ColorManager col = new ColorManager(new EFColorDal());
            //Color cl = new Color { ColorId = 8 , ColorName = "DarkGray" };
            //col.Add(cl);

            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var cars in carManager.GetCarsByBrandId(2))
            {
             //   Console.WriteLine("2. arabanın tanımı "+cars.Description);
            }
           

            ColorManager colorManager = new ColorManager(new EFColorDal());
            foreach (var item in colorManager.GetColorId(3))
            {
         //       Console.WriteLine("3 .rengin adı: "+item.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var item in brandManager.GetByBrandId(3))
            {
          //      Console.WriteLine("3. marka : "+item.BrandName);
            }
            

            
          
            

            Console.WriteLine("Başarılı");
            Console.ReadLine();
        }
    }
}
