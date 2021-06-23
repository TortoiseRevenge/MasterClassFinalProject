using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Services
{
    public interface IBarrelService
    {
        public Task<Barrel> GetBarrel(Guid id);
        public Task<Barrel> Update(Barrel model);
    }
}
