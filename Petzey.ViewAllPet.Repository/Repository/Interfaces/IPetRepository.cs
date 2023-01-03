using Petzey.ViewAllPet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Repository.Repository.Interfaces
{
    public interface IPetRepository
    {
        public ICollection<PetOwner> GetAllPetProfile();
        public bool AddPet(PetOwner petOwner);
        public PetOwner ViewPetOwnerProfile(int ownerId);
        public bool EditPetOwnerProfile(PetOwner petOwner);
    }
}
