using System.Threading.Tasks;
using edx_project.Models.DomainModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace edx_project.Models.ModelBinding
{
    public class GameModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var game = new Game();
            game.Player1 = new Player();
            game.Player2 = new Player();
            game.City = bindingContext.HttpContext.Request.Query["gameCity"];
            game.Player1.Name = bindingContext.HttpContext.Request.Query["p1Name"];
            game.Player1.Rank = int.Parse(bindingContext.HttpContext.Request.Query["p1Rank"]);
            game.Player2.Name = bindingContext.HttpContext.Request.Query["p2Name"];
            game.Player2.Rank = int.Parse(bindingContext.HttpContext.Request.Query["p2Rank"]);
            bindingContext.Result = ModelBindingResult.Success(game); // set the model binding result
            return Task.CompletedTask;
        }
    }
}
