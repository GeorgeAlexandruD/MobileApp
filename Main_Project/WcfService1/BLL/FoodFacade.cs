using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService1.DAL;
using WcfService1.Model;

namespace WcfService1.BLL
{
    public class FoodFacade
    {
        private FoodRepository foodRepository;

        public FoodFacade()
        {
            foodRepository = new FoodRepository();
        }

        public List<Food> GetFoodForUser()
        {
            return foodRepository.GetAllFood();
        }
    }
}