using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;

        //OdeToFoodDbContext is the class for Db Related operations
        public SqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }
        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Add(newRestaurant);
            return newRestaurant;
        }

        //This method is used to make change permanently in Db by calling savechanges method
        public int Commit()
        {
            return db.SaveChanges();
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);

            if(restaurant != null)
            {
                db.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return db.Restaurants.Find(id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByname(string name)
        {
            var quary = from r in db.Restaurants
                        where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                        orderby r.Name
                        select r;

            return quary;
        }

        public Restaurant Update(Restaurant updateRestaurant)
        {
            //Attached the existing entity data with updated one
            var entity = db.Restaurants.Attach(updateRestaurant);
            entity.State = EntityState.Modified; //It will tell to Entity framefork that it is update 
            return updateRestaurant;
        }
    }
}
