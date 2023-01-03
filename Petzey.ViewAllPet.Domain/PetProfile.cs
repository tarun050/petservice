using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Domain
{
    public class PetProfile
    {
        
        [Key]
        public int Id { get; set; }
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
