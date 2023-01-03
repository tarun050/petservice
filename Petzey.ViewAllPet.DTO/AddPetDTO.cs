using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.DTO
{
    public class AddPetDTO
    {
        public int PetOwnerId { get; set; }
        public string PetOwnerName { get; set; }
        public string PetName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string Allergies { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public string URL { get; set; }
    }
}
