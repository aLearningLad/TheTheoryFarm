using TheTheoryFarmAPI.Models.Domain;
using TheTheoryFarmAPI.Models.DTOs;

namespace TheTheoryFarmAPI.Repositories
{
    public interface ITheoryRepository
    {
        // get all
        Task<List<Theory>> GetAll();


        // get by id


        // create new 
        Task<Theory> CreateTheory(Theory theory);

    }
}
