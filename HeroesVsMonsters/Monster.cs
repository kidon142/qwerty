﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeroesVsMonsters
{
   
    public abstract class Monster : Personnage
    {
        public Monster(Coordonee Coordonee) : base(Coordonee)
        {
            Type TMonster = this.GetType();

// je suis un commentaire 
            if (this is ICuir)
            {
                TMonster.GetProperty("Cuir").SetMethod.Invoke(this, new object[] { De4.Lance() }); ;
            }

            if (this is IOr)
            {
                TMonster.GetProperty("Or").SetMethod.Invoke(this, new object[] { De6.Lance() }); ;
            }
        }
    }
}
