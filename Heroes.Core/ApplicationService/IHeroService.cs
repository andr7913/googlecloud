using System.Collections.Generic;
using Heroes.Entity;

namespace Heroes.Core.ApplicationService
{
    public interface IHeroService
    {
        Hero CreateHero(Hero createdHero);

        Hero GetHeroById(int id);

        List<Hero> GetAllHeroes();

        Hero UpdateHero(Hero updatedHero);

        Hero DeleteHero(int id);

    }
}