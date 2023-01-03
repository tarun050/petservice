using Fractions;
using Microsoft.EntityFrameworkCore;
using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.Repository.DataAccessLayer;
using Petzey.ViewAllPet.Repository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Repository.Repository.Implementations
{
    public class PetRepository : IPetRepository
    {
        ViewAllPetDbContext db = new ViewAllPetDbContext();

        public bool AddPet(PetOwner petOwner)
        {
            var pet = db.PetOwner.Find(petOwner.Id);
            if(pet != null)
            {
                db.PetOwner.Add(petOwner);
                db.SaveChanges();
                return true;
            }
                
                return false;
        }

        public bool EditPetOwnerProfile(PetOwner petOwner)
        {
            var pet = db.PetOwner.Find(petOwner.Id);
            if (pet != null )
            {
                db.Update(petOwner);
                db.SaveChanges();
                return true;
            }
            
            return false;
        }

        public ICollection<PetOwner> GetAllPetProfile()
        {
            ICollection<PetOwner> pet = db.PetOwner.Include(x => x.petProfiles).ToList();
            return pet;
        }

        public PetOwner ViewPetOwnerProfile(int ownerId)
        {
            PetOwner petOwner = db.PetOwner.Find(ownerId);
            if (petOwner == null)
            {
                return new InvalidNumberException();
            }
            return petOwner;
        }

    }
}
