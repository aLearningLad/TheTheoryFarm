
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using TheTheoryFarmAPI.Data;
using TheTheoryFarmAPI.Models.Domain;

namespace TheTheoryFarmAPI.Repositories
{
    public class SQLTheoryRepository : ITheoryRepository
    {
        private readonly TheoryDbContext theoryDbContext;

        public SQLTheoryRepository(TheoryDbContext theoryDbContext)
        {
            this.theoryDbContext = theoryDbContext;
        }

        public async Task<List<Theory>> GetAll()
        {

           return await theoryDbContext.Theories.ToListAsync();

           

        }

        
    }
}
