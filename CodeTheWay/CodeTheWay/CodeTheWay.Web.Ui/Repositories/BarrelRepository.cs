using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class BarrelRepository : IBarrelRepository
    {
        private AppDbContext AppDbContext;

        public BarrelRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }
        public async Task<Barrel> Create(Barrel barrel)
        {
            var result = await this.AppDbContext.AddAsync(barrel);
            await this.AppDbContext.SaveChangesAsync();

            return result.Entity;
        }
    }
}
