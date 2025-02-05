using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTheoryFarmAPI.Repositories;

namespace TheTheoryFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheoryController : ControllerBase
    {
        private readonly ITheoryRepository theoryRepository;


        // constructor so I can inject repository interface
        public TheoryController(ITheoryRepository theoryRepository)
        {
            this.theoryRepository = theoryRepository;
        }


        // get all theories
        [HttpGet]
        public async Task<IActionResult> GetAllTheories()
        {

            // get theory domain data 
            var theoryDomainData = await theoryRepository.GetAll();

            if(theoryDomainData == null)
            {
                return NotFound();
            }

            // implement automapper here for DTOs and domain
            return Ok(theoryDomainData);
           
        }

        // create a theory entry
        [HttpPost]
        public async Task<IActionResult> CreateTheory()
        {

            return Ok();
        }
    }
}
