﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ConsoletoWebAPI
{
    public class CustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var data = bindingContext.HttpContext.Request.Query;

            var result = data.TryGetValue("countries", out var country);

            if (result)
            {
                var array = country.ToString().Split('|');
                bindingContext.Result = ModelBindingResult.Success(array);
            }

            return Task.CompletedTask;
        }
    }
}
