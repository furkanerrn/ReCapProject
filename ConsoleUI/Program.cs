using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var cars in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine("2. arabanın tanımı "+cars.Description);
            }

            ColorManager colorManager = new ColorManager(new EFColorDal());
            foreach (var item in colorManager.GetColorId(3))
            {
                Console.WriteLine("3 .rengin adı: "+item.ColorName);
            }

            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var item in brandManager.GetByBrandId(3))
            {
                Console.WriteLine("3. marka : "+item.BrandName);
            }
            

            
          
            

            Console.WriteLine("Furkn Eren");
            Console.ReadLine();
        }
    }
}
