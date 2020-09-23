using System.Collections.Generic;
using Heroes.Entity;

namespace Heroes.Core.ApplicationService
{
    public interface IPetService
    {
        Pet CreatePet(Pet createdPet);

        Pet GetPetById(int id);

        Pet DeletePet(int id);

        List<Pet> GetAllPets();

        Pet UpdatePet(Pet updatedPet);

    }
}