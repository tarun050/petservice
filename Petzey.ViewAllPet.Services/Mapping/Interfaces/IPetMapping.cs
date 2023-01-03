using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Services.Mapping.Interfaces
{
    public interface IPetMapping
    {
        public ICollection<ViewAllPetDTO> ChangePetProfileToPetProfileCard(ICollection<PetOwner> pet);
        public PetOwner ChangePetProfileDtoToPetOwner(AddPetDTO addPetDTO);
        public PetOwnerProfileDTO ChangeOwnerProfileToOwnerProfileDto(PetOwner petOwnerProfiles);
        public PetOwner ChangePetOwnerProfileDtoToPetOwner(PetOwnerProfileDTO petOwnerProfile);
    }
}
