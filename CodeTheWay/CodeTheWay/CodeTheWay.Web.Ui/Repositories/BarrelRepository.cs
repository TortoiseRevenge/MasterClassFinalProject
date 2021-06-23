using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Barrel>> GetBarrel()
        {
            return await this.AppDbContext.Barrels.ToListAsync();
        }
        public async Task<Barrel> GetBarrel(Guid id)
        {
            return await AppDbContext.Barrels.FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
