using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Services.Services.Implementations;
using Petzey.ViewAllPet.Services.Services.Interfaces;

namespace Petzey.ViewAllPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddPetController : ControllerBase
    {
        IPetService service;
        public AddPetController()
        {
            service = new PetService();
        }
        [HttpPost]
        [Route("addpet")]
        public IActionResult AddPet(AddPetDTO addPetDTO)
        {
            try
            {
                if (addPetDTO == null)
                {
                    return BadRequest();
                }
                bool result = service.AddPet(addPetDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
