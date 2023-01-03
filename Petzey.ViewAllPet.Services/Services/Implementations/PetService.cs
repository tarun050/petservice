using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Repository.Repository.Implementations;
using Petzey.ViewAllPet.Repository.Repository.Interfaces;
using Petzey.ViewAllPet.Services.Mapping.Implementations;
using Petzey.ViewAllPet.Services.Mapping.Interfaces;
using Petzey.ViewAllPet.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Services.Services.Implementations
{
    public class PetService : IPetService
    {
        IPetRepository repo;
        IPetMapping mapping;
        public PetService()
        {
            repo = new PetRepository();
            mapping = new PetMapping();

        }

        public bool AddPet(AddPetDTO addPetDTO)
        {
            PetOwner petOwner = mapping.ChangePetProfileDtoToPetOwner(addPetDTO);
            return repo.AddPet(petOwner);
        }

        public bool EditPetOwnerProfile(PetOwnerProfileDTO petOwnerProfile)
        {
            PetOwner petOwner = mapping.ChangePetOwnerProfileDtoToPetOwner(petOwnerProfile);
            bool result = repo.EditPetOwnerProfile(petOwner);
            return result;
        }

        public ICollection<ViewAllPetDTO> GetAllPetProfiles()
        {
            ICollection<PetOwner> pet = repo.GetAllPetProfile();
            ICollection<ViewAllPetDTO> petProfileCards = mapping.ChangePetProfileToPetProfileCard(pet);
            return petProfileCards;
        }

        public PetOwnerProfileDTO ViewPetOwnerProfiles(int ownerId)
        {
            PetOwner petOwnerProfile = repo.ViewPetOwnerProfile(ownerId);
            PetOwnerProfileDTO petProfileDTO = mapping.ChangeOwnerProfileToOwnerProfileDto(petOwnerProfile);
            return petProfileDTO;
        }
    }
}
