using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StadiumApp2.Data.DAL;

namespace StadiumApp2.Data.Entities
{
    internal class StadionData
    {
        public void AddStadion(Stadions stadion)
        {
            StadiumApp2DbContext stadiumApp2DbContext = new StadiumApp2DbContext();
            stadiumApp2DbContext.Stadion.Add(stadion);
            stadiumApp2DbContext.SaveChanges();
        }
        public List<Stadions> GetAllStadiums()
        {
            StadiumApp2DbContext stadiumDbContext = new StadiumApp2DbContext();
            return stadiumDbContext.Stadion.ToList();
        }

        public Stadions GetStadiumById(int id)
        {
            StadiumApp2DbContext stadiumDbContext = new StadiumApp2DbContext();

            return stadiumDbContext.Stadion.Find(id);
        }

        public void DeleteStadiumById(int id)
        {
            StadiumApp2DbContext stadiumDbContext = new StadiumApp2DbContext();

            var data = stadiumDbContext.Stadion.FirstOrDefault(x => x.Id == id);
            stadiumDbContext.Stadion.Remove(data);
            stadiumDbContext.SaveChanges()
    }   }
    
}
