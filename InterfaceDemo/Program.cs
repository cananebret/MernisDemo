using InterfaceDemo.Abstract;
using InterfaceDemo.Concrete;
using System;
using InterfaceDemo.Entities;
using InterfaceDemo.Adapters;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdaptor());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1991,7,27),
                FirstName ="isim yazınız",
                LastName ="soyisim yazınız",
                NationalityId="kimlik no yazınız"
            });
            Console.ReadLine();
        }
    }
}
