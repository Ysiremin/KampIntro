using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yasir Çiftçi
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNo = "001";
            customer1.FirstName = "Yasir";
            customer1.LastName = "ÇİFTÇİ";
            customer1.TcNo = "123141231";

            //Kodlama.io Company

            CorporoteCustomer customer2 = new CorporoteCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "011";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "12341";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporoteCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
