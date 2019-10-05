﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_301044056_Assign01.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
    }
}
