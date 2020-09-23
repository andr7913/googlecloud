using Heroes.Entity;
using System.Collections.Generic;

namespace Heroes.Core.DomainService
{
    public interface IPetRepository
    {
        Pet CreatePet(Pet createdPet);

        List<Pet> GetAllPet();

        Pet GetPetById(int id);

        Pet UpdatePet(Pet updatedPet);

        Pet DeletePet(int id);
    }
}