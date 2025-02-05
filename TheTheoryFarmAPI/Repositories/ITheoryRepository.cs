using TheTheoryFarmAPI.Models.Domain;

namespace TheTheoryFarmAPI.Repositories
{
    public interface ITheoryRepository
    {
        Task<List<Theory>> GetAll();
    }
}
