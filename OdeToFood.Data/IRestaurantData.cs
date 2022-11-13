using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static OdeToFood.Core.Restaurant;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetRestaurantsByname(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updateRestaurant);
        Restaurant Add(Restaurant newRestaurant);
        Restaurant Delete(int  id);
        int GetCountOfRestaurants();
        int Commit(); //This method is used when we have any update from DB side to commit the changes
    }
}
