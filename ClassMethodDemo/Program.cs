using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 50;
            customer1.FirstName = "John";
            customer1.LastName = "Locke";

            Customer customer2 = new Customer();
            customer2.Id = 51;
            customer2.FirstName = "John Ronald Reuel";
            customer2.LastName = "Tolkien";

            Customer customer3 = new Customer();
            customer3.Id = 52;
            customer3.FirstName = "Paul";
            customer3.LastName = "McCartney";

            CustomerManager<Customer> customerManager = new CustomerManager<Customer>();
            customerManager.add(customer1);
            customerManager.add(customer2);
            customerManager.add(customer3);

            int id; string name, lastName;
            Console.WriteLine("Deger eklemek icin 1,devam etmek icin 2 tuslayiniz..");
            int val = Convert.ToInt16(Console.ReadLine());
            while (val == 1)
            {
                Console.WriteLine("Eklemek istediginiz musteriye ait Id,İsim,Soyisim giriniz..");
                id = Convert.ToInt16(Console.ReadLine());
                name = Convert.ToString(Console.ReadLine());
                lastName = Convert.ToString(Console.ReadLine());
                Customer customer = new Customer();
                customer.Id = id;
                customer.FirstName = name;
                customer.LastName = lastName;
                customerManager.add(customer);
                Console.WriteLine("Deger eklemeye devam etmek icin 1,islemden cikis yapmak icin 2 tuslayiniz..");
                val = Convert.ToInt16(Console.ReadLine());
            }
            customerManager.list();
            Console.WriteLine("Deger silmek icin 1,devam etmek icin 2 tuslayiniz..");
            val = Convert.ToInt16(Console.ReadLine());
            while (val == 1)
            {
                Console.WriteLine("Silmek istediginiz musteriye ait Id giriniz..");
                id = Convert.ToInt16(Console.ReadLine());
                customerManager.deleteManuel(id);
                Console.WriteLine("Deger silmeye devam etmek icin 1,islemden cikis yapmak icin 2 tuslayiniz..");
                val = Convert.ToInt16(Console.ReadLine());
            }

            customerManager.list();
            customerManager.delete(customer2);
            customerManager.list();

            Console.WriteLine("\n\n");

            MyDictionary<int,string> dictionary= new MyDictionary<int, string>();
            int key;string value;
            dictionary.Add(customer1.Id, customer1.FirstName+" "+customer1.LastName);
            dictionary.Add(customer2.Id, customer1.FirstName + " " + customer2.LastName);
            dictionary.Add(customer3.Id, customer1.FirstName + " " + customer3.LastName);
            dictionary.List();
            Console.WriteLine("Deger ekleme islemi icin 1,devam etmek icin 2 tuslayiniz..");
            val = Convert.ToInt16(Console.ReadLine());
            while (val == 1) 
            {
                Console.WriteLine("Key ve Vaule degerlerini giriniz..");
                key = Convert.ToInt16(Console.ReadLine());
                value = Convert.ToString(Console.ReadLine());
                dictionary.Add(key, value);
                Console.WriteLine("Deger ekleme islemine devam etmek icin 1,islemden cikis yapmak icin 2 tuslayiniz..");
                val = Convert.ToInt16(Console.ReadLine());
            }
            dictionary.List();
        }
    }
}
