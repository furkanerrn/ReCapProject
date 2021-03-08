using Business.Concrete;
using Business.Constants;
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
            ColorManager colorManager2 = new ColorManager(new EFColorDal());
            colorManager2.Add(new Color { ColorName = "Platon" });
            //CustomerManager customerManager = new CustomerManager(new EFCustomerDal());
            //customerManager.Add(new Customers { UserId = 8, CompanyName = "Nestle" });
            //foreach (var item in customerManager.GetCustomerById(2).Data)
            //{
            //    Console.WriteLine(item.CompanyName +"  / " +item.UserId);
            //}

            //UserManager userManager = new UserManager(new EFUserDal());
            //foreach (var item in userManager.GetAll().Data)
            //{
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("Ad: "+item.FirstName + "   /  Soyad: "+item.LastName+"  /  Email: "+item.Email);
            //}

            RentalManager rentalManager = new RentalManager(new EFRentalDal());
            //  rentalManager.Add(new Rentals { CarId = 1, CustomerId=2, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 10, 29) });

            var result = rentalManager.GetRentalDetails(2);
            Console.WriteLine(result.Message);
            foreach (var item in rentalManager.GetRentalDetails(2).Data)
            {
                Console.WriteLine("Mülteri Id: " + item.CustomerId + " || " + "Araba numarası: " + item.CarId + "  || " + "Kiralama tarihi " + item.RentDate + "  || " + "Dönüş Tarihi " + item.ReturnDate);
            }

            Console.WriteLine("*******");
            var res = rentalManager.GetAll();
            Console.WriteLine(res.Message);
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine( "Mülteri Id: "+item.CustomerId +" || "+"Araba numarası: "+ item.CarId +"  || " + "Kiralama tarihi "+item.RentDate+ "  || "+"Dönüş Tarihi " +item.ReturnDate );
               
            }


           
            Console.WriteLine("Başarılı");
            Console.Read();

           
           

            CustomerManager ct = new CustomerManager(new EFCustomerDal());
            Customers c = new Customers { CompanyName = "Aselsan" ,UserId=2};
          




            

          //  Console.ForegroundColor = ConsoleColor.Cyan;

          //  CarManager manager = new CarManager(new EFCarDal());
          //  var result = manager.GetProductDetails();
          //  if (result.Success==true)
          //  {
          //      foreach (var thecar in manager.GetProductDetails().Data)
          //      {
          //          Console.WriteLine("Detaylar getirildi");
          //          Console.WriteLine(thecar.CarId + "/  "+"Tanım :" + thecar.Descriptions + " / " +"Ücret : "+ thecar.DailyPrice + " / " +"  Renk :" + thecar.ColorName);
                   
          //      }
          //  }
          //  else
          //  {
          //      Console.WriteLine(result.Message);
          //  }
           
            
          //  CarManager carManagerr = new CarManager(new EFCarDal());
          //  foreach (var car in carManagerr.GetCarsByColorId(2).Data) 
          //  {
          //      Console.WriteLine("2 numaralı renk id sıne sahip araba: {0}",car.Description);
          //  }

            ColorManager colorManager1 = new ColorManager(new EFColorDal());

          // colorManager1.Add(new Color {  ColorName = "Brown" });
           // Console.WriteLine("Brown color added");

            CarManager cm = new CarManager(new EFCarDal());
            //Car skoda = new Car { BrandId = 5, CarId = 8, ColorId = 2, DailyPrice = 2000, Description = "Skoda araba", ModelYear = 2015 };
            //cm.Add(skoda);
           // cm.Update(new Car {  CarId=4, Description="bugatti araba"});

            foreach (var thecar in cm.GetCarById(5).Data)
            {
         //       Console.WriteLine(thecar.CarId+" "+thecar.Description+" "+thecar.DailyPrice);
           //     Console.WriteLine("Bugatti arabaya ait veriler başarıyla getirildi");
            }
            

            //ColorManager col = new ColorManager(new EFColorDal());
            //Color cl = new Color { ColorId = 8 , ColorName = "DarkGray" };
            //col.Add(cl);

            CarManager carManager = new CarManager(new EFCarDal());
            foreach (var cars in carManager.GetCarById(2).Data)
            {
             //   Console.WriteLine("2. arabanın tanımı "+cars.Description);
            }
           

            ColorManager colorManager = new ColorManager(new EFColorDal());
            foreach (var item in colorManager.GetColorId(3).Data)
            {
         //       Console.WriteLine("3 .rengin adı: "+item.ColorName);
            }
           

            BrandManager brandManager = new BrandManager(new EFBrandDal());
            foreach (var item in brandManager.GetByBrandId(3).Data)
            {
          //      Console.WriteLine("3. marka : "+item.BrandName);
            }
            

            
          
            

            Console.WriteLine("Başarılı");
            Console.ReadLine();
        }
    }
}
