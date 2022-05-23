using AccountTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountTask.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataBaseContext context)
        {
            context.Database.EnsureCreated();
            if (context.Accounts.Any())
            {
                return;
            }
            var accounts = new Account[]
            {
                new Account { 
                    FullName = "Иванов Иван"
                    , PropertyAddress= new Address
                    {
                        Locality = "Екатеринбург"
                        , Street = "Пушкина"
                        , Building = 23
                        , Case = "а"
                        , ApartmentNumber = 45
                        , Area = 45.5
                        , ResidentsCount = 2
                    }
                    , OpeningDate = DateTime.Today },

                new Account 
                { 
                    FullName = "Петрова Анна"
                    , PropertyAddress = new Address
                    {
                        Locality = "Екатеринбург"
                        , Street = "Татищева"
                        , Building = 3
                        , ApartmentNumber = 111
                        , Area = 105
                        , ResidentsCount = 4
                    }
                    , OpeningDate = DateTime.Today 
                }
            };
            foreach (Account a in accounts)
            {
                context.Accounts.Add(a);
            }
            context.SaveChanges();
        }
    }
}
