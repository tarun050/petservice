using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Repository.DataAccessLayer;
using Petzey.ViewAllPet.Repository.Repository.Implementations;
using Petzey.ViewAllPet.Repository.Repository.Interfaces;
using Petzey.ViewAllPet.Services.Services.Implementations;
using Petzey.ViewAllPet.Services.Services.Interfaces;

namespace Petzey.ViewAllPets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewAllPetController : ControllerBase
    {
        IPetService service;
        public ViewAllPetController()
        {
            service = new PetService();
        }

        [HttpGet]
        [Route("viewAllPet")]
        public IActionResult ViewAllPet()
        {
            try
            {
                ICollection<ViewAllPetDTO> petProfileCards = service.GetAllPetProfiles();
                if(petProfileCards == null)
                {
                    return NotFound();
                }
                return Ok(petProfileCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
