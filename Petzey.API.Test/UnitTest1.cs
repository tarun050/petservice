using AutoFixture;
using Moq;
using Petzey.ViewAllPet.Domain;
using Petzey.ViewAllPet.DTO;
using Petzey.ViewAllPet.Services.Services.Implementations;
using Petzey.ViewAllPet.Services.Services.Interfaces;
using Petzey.ViewAllPets.API.Controllers;

namespace Petzey.API.Test
{
    public class UnitTest1
    {
        //public readonly IFixture fixture;
        public readonly IPetService servicemock;
        public readonly PetController pet;

        UnitTest1()
        {
            //fixture = new Fixture();
            servicemock = new PetService();
            pet = new PetController();
        }
        [Fact]
        public void viewAllPet()
        {
            var result = pet.ViewAllPet();
        }
    }
}