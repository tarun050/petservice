using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.DTO
{
    public class PetOwnerProfileDTO
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string Location { get; set; }
        public string PhoneNo { get; set; }
        public string ImageUrl { get; set; }
    }
}
