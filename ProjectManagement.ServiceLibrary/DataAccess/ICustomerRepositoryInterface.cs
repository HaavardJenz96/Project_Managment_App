using ProjectManagment.Data.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectManagement.ServiceLibrary.DataAccess
{
    public interface ICustomerRepositoryInterface
    {
        Task<IEnumerable<CustomerEntity>> GetAllAsync();
        Task<CustomerEntity> GetByIdAsync(int id);
        Task AddAsync(CustomerEntity customer);
        Task UpdateAsync(CustomerEntity customer);
        Task DeleteAsync(int id);
        Task SaveChangesAsync();
    
  

    }

}
