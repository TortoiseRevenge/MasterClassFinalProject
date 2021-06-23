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

    }
}
