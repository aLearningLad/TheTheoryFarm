
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheTheoryFarmAPI.Data;
using TheTheoryFarmAPI.Models.Domain;
using TheTheoryFarmAPI.Models.DTOs;

namespace TheTheoryFarmAPI.Repositories
{
    public class SQLTheoryRepository : ITheoryRepository
    {
        private readonly TheoryDbContext theoryDbContext;
        private readonly IMapper mapper;

        public SQLTheoryRepository(TheoryDbContext theoryDbContext)
        {
            this.theoryDbContext = theoryDbContext;
            
        }

        // get all
        public async Task<List<Theory>> GetAll()
        {

           return await theoryDbContext.Theories.ToListAsync();

           

        }


        // create new
        public async Task<Theory> CreateTheory([FromBody] Theory theory)
        {
            await theoryDbContext.Theories.AddAsync(theory);
            await theoryDbContext.SaveChangesAsync();
            return theory;

        }
     
        
        // get by id
        public async Task<Theory?> GetTheoryById([FromRoute] Guid id) {

           return await theoryDbContext.Theories.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
