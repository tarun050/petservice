using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Services.Services.Implementations;
using Petzey.ViewAllPet.Services.Services.Interfaces;

namespace Petzey.Pet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetOwnerProfileController : ControllerBase
    {
        IPetService service;
        public PetOwnerProfileController()
        {
            service = new PetService();
        }
        [HttpGet]
        [Route("Id")]

        public IActionResult ViewAllPetProfile(int ownerId)
        {
            try
            {
                if (ownerId == null)
                {
                    return NotFound();
                }

                PetOwnerProfileDTO petprofile = service.ViewPetOwnerProfiles(ownerId);
                return Ok(petprofile);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
