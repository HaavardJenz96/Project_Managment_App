using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using ProjectManagment.Data.Enteties;
using EFCoreExample;

namespace ProjectManagement.ServiceLibrary.DataAccess
{
    public class CustomerRepository : ICustomerRepositoryInterface
    {
        private AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<ProjectManagment.Data.Enteties.CustomerEntity>> GetAllAsync()
        {
            return await context.customers.ToListAsync(); 
        }

        public async Task<ProjectManagment.Data.Enteties.CustomerEntity> GetByIdAsync(int id)
        {
            return await context.customers.FindAsync(id);
        }

        public async Task AddAsync(ProjectManagment.Data.Enteties.CustomerEntity customer)
        {
            context.customers.Add(customer);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ProjectManagment.Data.Enteties.CustomerEntity customer)
        {
            context.Entry(customer).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await context.customers.FindAsync(id);
            if (customer != null)
            {
                context.customers.Remove(customer);
                await context.SaveChangesAsync();
            }
        }
        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

    }
}
