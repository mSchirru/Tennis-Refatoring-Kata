﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis;

namespace Tennis_Refatoring_Kata.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        public void AtualizarPlacar(Player player)
        {
            player.score += 1; //Update player score to plus 1
        }
    }
}
