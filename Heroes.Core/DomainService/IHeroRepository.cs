﻿using System.Collections.Generic;
using Heroes.Entity;

namespace Heroes.Core.DomainService
{
    public interface IHeroRepository
    {
        Hero CreateHero(Hero createdHero);

        List<Hero> GetAllHeroes();

        Hero GetHeroById(int id);

        Hero UpdateHero(Hero updatedHero);

        Hero DeleteHero(int id);

    }
}