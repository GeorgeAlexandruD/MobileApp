using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.Model;

namespace WcfService1.DAL
{
    public class FoodRepository
    {
        public List<Food> GetAllFood()
        {
            //connect to database and execute sql and return the data
            return new List<Food>();
        }
    }
}