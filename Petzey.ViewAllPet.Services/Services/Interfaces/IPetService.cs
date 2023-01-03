using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Services.Services.Interfaces
{
    public interface IPetService
    {
        public ICollection<ViewAllPetDTO> GetAllPetProfiles();
        public bool AddPet(AddPetDTO addPetDTO);
        public PetOwnerProfileDTO ViewPetOwnerProfiles(int ownerId);
        public bool EditPetOwnerProfile(PetOwnerProfileDTO petOwnerProfile);
    }
}
