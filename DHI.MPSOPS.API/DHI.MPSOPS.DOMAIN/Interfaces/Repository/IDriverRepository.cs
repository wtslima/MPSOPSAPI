using System.Collections.Generic;
using System.Threading.Tasks;
using DHI.MPSOPS.DOMAIN.Model;

namespace DHI.MPSOPS.DOMAIN.Interfaces.Repository
{
    public interface IDriverRepository
    {
        Task<Driver> GetDetailsDriverById(string id);
        Task<IList<Driver>> GetAllDrivers();
        Task<bool> UpdateDrivers(Driver driver);
        Task<bool> AddNewDrivers(Driver driver);
    }
}