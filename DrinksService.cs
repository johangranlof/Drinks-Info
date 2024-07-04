

using Drinks_info_app.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Drinks_info_app
{
    public class DrinksService
    {
        public void GetCategories()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if(response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

                List<Category> returnedList = serialize.CategoriesList;

                TableVisualisationEngine.ShowTable(returnedList, "Categories Menu");
            }
        }
    }
}
