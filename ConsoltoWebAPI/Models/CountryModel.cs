using Microsoft.AspNetCore.Mvc;

namespace ConsoletoWebAPI.Models
{
    [ModelBinder(typeof(CustomBinderCountryDetails))]
    public class CountryModel
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
    }
}
