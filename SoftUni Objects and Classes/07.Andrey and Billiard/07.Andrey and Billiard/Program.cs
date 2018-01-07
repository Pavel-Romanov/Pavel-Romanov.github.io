using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, decimal> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> OnOffer = new Dictionary<string, decimal>(); // prices
            int n = int.Parse(Console.ReadLine());

            
            // cust.ShopList = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                OnOffer.Add(line[0], decimal.Parse(line[1]));
            }

            List<Customer> customers = new List<Customer>();
            var lines = Console.ReadLine().Split('-',',');
            while(lines[0] != "end of clients")
            {
                Customer cust = new Customer();
                cust.Name = lines[0];
                cust.ShopList = new Dictionary<string, decimal>();
                cust.ShopList.Add(lines[1], decimal.Parse(lines[2]));
                customers.Add(cust);

                lines = Console.ReadLine().Split('-',',');
            }

            List<Customer> result = new List<Customer>();
            for (int i = 0; i < customers.Count; i++)
            {
                //customers[i].Bill = OnOffer.Values * customers[i].ShopList.Values;
                if(customers[i].ShopList.Keys == OnOffer.Keys)
                {
                    result.Add(customers[i]);
                }
            }
            foreach (Customer customer in result)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string,decimal> item in customer.ShopList)
                {
                    Console.WriteLine($"--- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: { customer.Bill:F2}");
            }
        }
    }
}
/*
4
Cola-1.25
Sandwich-2.30
Bira-2
SOk-2
Toshko-Bira,3
Mira-Sandwich,1
end of clients
*/