using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CustomerDebtSystem
{
    public class DAL
    {
        public void AddRecord(Customer customer)
        {
            using (CustomerContext context = new CustomerContext())
            {
                Customer customer1 = context.Records.FirstOrDefault(x => x.İsim.ToLower() == customer.İsim.ToLower());
                if (customer1 != null)
                {
                    customer.CustomerId = customer1.CustomerId;
                    customer.İsim = customer1.İsim;
                }
                else
                {
                    List<Customer> list = context.Records.ToList();
                    int max = 0;
                    foreach (Customer c in list)
                    {
                        max = max >= c.CustomerId ? max : c.CustomerId;
                    }
                    customer.CustomerId = max + 1;
                }
                context.Records.Add(customer);
                context.SaveChanges();
                CalculateTotal(customer);
            }
        }
        public void CalculateTotal(Customer customer)
        {
            if (customer == null) return;
            using (CustomerContext context = new CustomerContext())
            {
                List<Customer> list = context.Records.Where(p => p.CustomerId == customer.CustomerId).ToList();
                Total total = context.Totals.FirstOrDefault(p => p.CustomerId == customer.CustomerId);
                if (total != null)
                {
                    decimal res = 0;
                    foreach (Customer customer1 in list)
                    {
                        res += customer1.Borç - customer1.Alacak;
                    }
                    total.Totalres = res;
                    if (res == 0) context.Entry(total).State = EntityState.Deleted;
                    else context.Entry(total).State = EntityState.Modified;
                }
                else
                {
                    decimal res = 0;
                    foreach (Customer customer1 in list)
                    {
                        res += customer1.Borç - customer1.Alacak;
                    }
                    Total total1 = new Total
                    {
                        Totalres = res,
                        CustomerId = customer.CustomerId,
                        İsim = customer.İsim
                    };
                    context.Totals.Add(total1);
                }
                context.SaveChanges();
            }
        }
        public void UpdateRecord(Customer customer)
        {
            using (CustomerContext context = new CustomerContext())
            {
                context.Entry(customer).State = EntityState.Modified;
                context.SaveChanges();
                CalculateTotal(customer);
            }
        }
        public void DeleteRecord(int id)
        {
            using (CustomerContext context = new CustomerContext())
            {
                Customer customer = context.Records.FirstOrDefault(p => p.Id == id);
                context.Entry(customer).State = EntityState.Deleted;
                context.SaveChanges();
                CalculateTotal(customer);
            }
        }
        public List<Customer> GetCustomers()
        {
            using (CustomerContext context = new CustomerContext())
            {
                List<Customer> l = context.Records.ToList();
                l.Sort((c1, c2) => c1.Tarih.CompareTo(c2.Tarih));
                return l;
            }
        }
        public List<Customer> GetByName(string name)
        {
            using (CustomerContext context = new CustomerContext())
            {
                return context.Records.Where(p => p.İsim.ToLower().Contains(name.ToLower())).ToList();
            }
        }
        public List<Total> GetTotals()
        {
            using (CustomerContext context = new CustomerContext())
            {
                return context.Totals.ToList();
            }
        }
    }
}
