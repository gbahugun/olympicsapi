using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OlympicsWeb.Data;

namespace OlympicsWeb.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            if (!db.Countries.Any())
            {
                db.Countries.Add(new Country
                {
                    Rank = 1,
                    Name = "Norway",
                    Gold = 14,
                    Silver = 14,
                    Bronze = 11,
                    Total = 39
                });
                db.Countries.Add(new Country
                {
                    Rank = 2,
                    Name = "Germany",
                    Gold = 14,
                    Silver = 10,
                    Bronze = 7,
                    Total = 31
                });
                db.Countries.Add(new Country
                {
                    Rank = 3,
                    Name = "Canada",
                    Gold = 11,
                    Silver = 8,
                    Bronze = 10,
                    Total = 29
                });
                db.Countries.Add(new Country
                {
                    Rank = 4,
                    Name = "United States",
                    Gold = 9,
                    Silver = 8,
                    Bronze = 6,
                    Total = 23
                });
                db.Countries.Add(new Country
                {
                    Rank = 5,
                    Name = "Netherlands",
                    Gold = 8,
                    Silver = 6,
                    Bronze = 6,
                    Total = 20
                });
                db.SaveChanges();
            }
        }
    }
}
