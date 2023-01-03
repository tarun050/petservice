using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Petzey.ViewAllPet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ViewAllPet.Repository.DataAccessLayer
{
    public class ViewAllPetDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:petzeyproject.database.windows.net,1433;Initial Catalog=Petzey-Pet;Persist Security Info=False;User ID=Tarun_050;Password=Relax@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public DbSet<PetOwner> PetOwner { get; set; }
    }
}
 