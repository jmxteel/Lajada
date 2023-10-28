using Abp.Domain.Entities;
using AutoMapper;
using Lajada.Domain.Entities;
using Lajada.Services.IServiceRepository;
using Lajada.Services.Models;
using Lajada.Services.ServiceRepository;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Lajada.API.Controllers
{
    [ApiController]
    [Route("api/personalinformation")]
    public class PersonalInformationController: ControllerBase
    {
        private readonly IPersonalInformationService _personalInformationService;
        private readonly IMapper _mapper;

        public PersonalInformationController(IPersonalInformationService personalInformationService, IMapper mapper)
        {
            _personalInformationService = personalInformationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personal_Information>>> GetAll()
        {
            var result = await _personalInformationService.GetAllAsync();
            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetPersonalInformation")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _personalInformationService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Personal_InformationDto personalInformationdData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            try
            {
                await _personalInformationService.AddAsync(personalInformationdData);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return CreatedAtRoute("GetPersonalInformation",
                new 
                    { 
                        Id = personalInformationdData.Id,
                    },
                personalInformationdData
                );
        }

    }
}
