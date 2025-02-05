using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheTheoryFarmAPI.Models.Domain;
using TheTheoryFarmAPI.Models.DTOs;
using TheTheoryFarmAPI.Repositories;

namespace TheTheoryFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheoryController : ControllerBase
    {
        private readonly ITheoryRepository theoryRepository;
        private readonly IMapper mapper;


        // constructor so I can inject repository interface
        public TheoryController(ITheoryRepository theoryRepository, IMapper mapper)
        {
            this.theoryRepository = theoryRepository;
            this.mapper = mapper;
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
        public async Task<IActionResult> CreateTheory([FromBody] AddTheoryRequestDto addTheoryRequestDto)
        {

            // map dto to domain 
            var theoryDomainModel = mapper.Map<Theory>(addTheoryRequestDto);
            var response = await theoryRepository.CreateTheory(theoryDomainModel);

            return Ok(response);
        }
    }
}
