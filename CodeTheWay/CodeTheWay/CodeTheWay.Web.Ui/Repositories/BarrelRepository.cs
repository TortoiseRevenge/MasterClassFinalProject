﻿using CodeTheWay.Web.Ui.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class BarrelRepository : IBarrelRepository
    {
        private AppDbContext AppDbContext;

        public BarrelRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }

        public async Task<List<Barrel>> GetBarrels()
        {
            return await this.AppDbContext.Barrels.ToListAsync();


        }
    }
}
