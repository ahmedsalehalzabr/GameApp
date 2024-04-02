using GameZone.Models;
using GameZone.ViewModels;

namespace GameZone.Services
{
    public interface IGamesService
    {
       // IEnumerable<Game> GetAll();
      
        Task Create(CreateGameFormVM model);
        //Task<Game?> Update(EditGameFormVM model);
       
    }
}
