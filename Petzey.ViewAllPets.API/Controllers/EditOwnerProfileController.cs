using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Services.Services.Implementations;
using Petzey.ViewAllPet.Services.Services.Interfaces;

namespace Petzey.Pet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EditOwnerProfileController : ControllerBase
    {
        IPetService service;
        public EditOwnerProfileController()
        {
            service = new PetService();
        }
        [HttpPut]
        [Route("Id")]
        public IActionResult EditPetOwnerProfile(PetOwnerProfileDTO petOwnerProfile)
        {

            try
            {
                if (petOwnerProfile == null)
                {
                    return NotFound();
                }
                bool result = service.EditPetOwnerProfile(petOwnerProfile);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
