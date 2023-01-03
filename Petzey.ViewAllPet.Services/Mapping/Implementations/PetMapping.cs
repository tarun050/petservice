using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Services.Mapping.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Services.Mapping.Implementations
{
    public class PetMapping : IPetMapping
    {
        public PetOwnerProfileDTO ChangeOwnerProfileToOwnerProfileDto(PetOwner petOwnerProfiles)
        {
            PetOwnerProfileDTO pet = new PetOwnerProfileDTO()
            {
                OwnerId = petOwnerProfiles.Id,
                OwnerName = petOwnerProfiles.PetOwnerName,
                Location = petOwnerProfiles.Location,
                PhoneNo = petOwnerProfiles.PhoneNo,
                ImageUrl = petOwnerProfiles.ImageUrl,
            };
            return pet;
        }

        public PetOwner ChangePetOwnerProfileDtoToPetOwner(PetOwnerProfileDTO petOwnerProfile)
        {
            PetOwner petOwner = new PetOwner()
            {
                Id = petOwnerProfile.OwnerId,
                PetOwnerName = petOwnerProfile.OwnerName,
                PhoneNo = petOwnerProfile.PhoneNo,
                Location = petOwnerProfile.Location,
                ImageUrl = petOwnerProfile.ImageUrl
            };
            return petOwner;
        }

        public PetOwner ChangePetProfileDtoToPetOwner(AddPetDTO addPetDTO)
        {
            PetOwner petOwner = new PetOwner()
            {
                Id = addPetDTO.PetOwnerId,
                PetOwnerName = addPetDTO.PetOwnerName,
                petProfiles = new List<PetProfile>()
                {
                    new PetProfile()
                    {
                        PetName = addPetDTO.PetName,
                        Age =addPetDTO.Age,
                        Species = addPetDTO.Species,
                        Allergies = addPetDTO.Allergies,
                        BloodGroup = addPetDTO.BloodGroup,
                        DateOfBirth= addPetDTO.DateOfBirth,
                        Gender = addPetDTO.Gender,
                        URL = addPetDTO.URL
                    }
                }
            };
            return petOwner;
        }

        public ICollection<ViewAllPetDTO> ChangePetProfileToPetProfileCard(ICollection<PetOwner> pets)
        {
            ICollection<ViewAllPetDTO> petProfileCards = new List<ViewAllPetDTO>();
                foreach (var pet in pets)
                {
                    foreach (var p in pet.petProfiles)
                    {
                        ViewAllPetDTO petProfileCard = new ViewAllPetDTO();
                        petProfileCard.Name = p.PetName;
                        petProfileCard.Gender = p.Gender;
                        petProfileCard.Age = p.Age;
                        petProfileCard.PetOwnerName = pet.PetOwnerName;
                        petProfileCard.URL = p.URL;
                        petProfileCards.Add(petProfileCard);
                    }
                }
                return petProfileCards;
        }
    }
}
