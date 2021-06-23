using System;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Barrel> GetBarrel(Guid id) {
            return await this.AppDbContext.Barrels.FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<Barrel> Update(Barrel model) {
            var result = AppDbContext.Barrels.Update(model);
            await AppDbContext.SaveChangesAsync();
            return result.Entity;
        }

    }
}
