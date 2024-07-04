using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks_info_app
{
    public class Userinput
    {
        DrinksService drinksService = new();

        internal void GetCategoriesInput()
        {
            drinksService.GetCategories();
        }
    }
}
