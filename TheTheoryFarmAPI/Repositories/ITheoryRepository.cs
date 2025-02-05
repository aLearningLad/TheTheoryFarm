using Microsoft.AspNetCore.Mvc;
using TheTheoryFarmAPI.Models.Domain;
using TheTheoryFarmAPI.Models.DTOs;

namespace TheTheoryFarmAPI.Repositories
{
    public interface ITheoryRepository
    {
        // get all
        Task<List<Theory>> GetAll();


        // get by id
        Task<Theory?> GetTheoryById([FromRoute]Guid id);

        // create new 
        Task<Theory> CreateTheory(Theory theory);

    }
}
