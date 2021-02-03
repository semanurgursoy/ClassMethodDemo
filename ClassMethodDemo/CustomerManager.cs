using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager<T>
    {

        public List<Customer> customers = new List<Customer>();

        public void add(Customer customer)
        {
            customers.Add(customer);
        }
        public void delete(Customer customer)
        {
            customers.Remove(customer);
        }
        public void deleteManuel(int id)
        {
            for(int i=0;i<customers.Count;i++)
            {
                if (id == customers[i].Id)
                {
                    customers.Remove(customers[i]);
                }
            }
        }
        public void list()
        {
            for(int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(customers[i].Id+"\t"+customers[i].FirstName+"\t"+customers[i].LastName);
            }
            Console.WriteLine();
        }
    }
}
