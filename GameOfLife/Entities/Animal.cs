using System;
using GameOfLife.Entities.Interfaces;

namespace GameOfLife.Entities;

public abstract class Animal : Entity, ICanMove, ICanBreed
{
    public void Die()
    {
        if (Hp < 0)
        {
            //Destroys entity
        }
    }
}

