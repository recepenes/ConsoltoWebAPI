using ConsoletoWebAPI.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoletoWebAPI
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelname = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelname);
            var result = value.FirstValue;

            if (!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                CountryId = id,
                Area = 444,
                Name = "Turkey",
                Population = 8000,
            };

            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
