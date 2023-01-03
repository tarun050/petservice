using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Domain
{
    public class PetOwner
    {
        [Key]
        public int Id { get; set; }
        public string PetOwnerName { get; set; }
        public string PhoneNo { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
        public List<PetProfile> petProfiles { get; set; }
    }
}
