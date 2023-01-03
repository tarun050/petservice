using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPets.API.Controllers;

namespace ViewAllPet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ViewAllPetController pet = new ViewAllPetController();
            var result = pet.ViewAllPet();
        }
        [TestMethod]
        public void TestMethod2()
        {
            PetOwner petOwner = new PetOwner();
            petOwner.Id = 2;
            petOwner.petProfiles = new List<PetProfile>()
            {
                new PetProfile()
                {
                    Id = 2,
                    DateOfBirth = DateTime.Now,
                    BloodGroup="A+",
                    Allergies="rash",
                    Gender ="Male",
                    Species = "Dog"
                }
        };

        }
    }
}