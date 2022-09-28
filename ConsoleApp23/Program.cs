using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
   
    public class Customer
    {
       public string Name { get; set; }
       public string Loan { get; set; }
    }
    public class Account
    {
        public string type1 { get; set; }


        public List<Customer> cust = new List<Customer>();
    }
    public class Program
    {

       static void Main(string[] args)
          {
            List<Account> acc = new List<Account>()
            {
                new Account
                {
                    type1="Saving",
                    cust={
                        new Customer { Name="Aniket wable",Loan="Home Loan"},
                        new Customer{Name="omkar Gujr",Loan="Home Loan,Personal loan"},
                        new Customer{Name="Rahul Rana",Loan="null"}
                    }
                },



                new Account
                {
                    type1="Current",
                    cust =
                    {
                        new Customer{Name="pratibha Rana",Loan="Gold Loan,Home Loan"},
                        new Customer{Name="Santosh hargude",Loan="Car loan,personal Loan"},
                        new Customer{Name="rajesh bharti",Loan="HomeLoan"},
                        new Customer{Name="Shankar kanvi",Loan="null"},
                        new Customer{Name="Anil Padval",Loan="Home Loan,personal loan,Car loan"},

                    }
                }
            };
            foreach(Account i in acc)
            {
                Console.WriteLine(i.type1);
                    foreach(Customer c in i.cust)
                {
                    Console.WriteLine($"      Name={c.Name} \n      Loan={c.Loan} \n");
                }
            }
        }
    }
}
