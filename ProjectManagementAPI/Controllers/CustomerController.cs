﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreExample;
using ProjectManagement.ServiceLibrary.DataAccess;
using NuGet.Protocol.Core.Types;
using ProjectManagment.Data.Enteties;

namespace ProjectManagementAPI.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private ICustomerRepositoryInterface _customerRepository;
        
        public CustomerController(ICustomerRepositoryInterface customerRepository)
        {
            _customerRepository = customerRepository;
        }

        //private readonly AppDbContext _context;

        //public CustomerController(AppDbContext context)
        //{
        //    _context = context;
        //}
        
        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectManagment.Data.Enteties.Customer>>> Getcustomers()
        {
            var customers = await _customerRepository.GetAllAsync(); // Legg til await her
            
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Customer_Since: {customer.CustomerSince}");

            }

            return Ok(customers);

          

        }


        //    // GET: api/Customers/5
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<Customer>> GetCustomer(int id)
        //    {
        //        var customer = await _context.customers.FindAsync(id);

        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        return customer;
        //    }

        //    // PUT: api/Customers/5
        //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //    [HttpPut("{id}")]
        //    public async Task<IActionResult> PutCustomer(int id, Customer customer)
        //    {
        //        if (id != customer.id)
        //        {
        //            return BadRequest();
        //        }

        //        _context.Entry(customer).State = EntityState.Modified;

        //        try
        //        {
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!CustomerExists(id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }

        //        return NoContent();
        //    }

        //    // POST: api/Customers
        //    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //    [HttpPost]
        //    public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        //    {
        //        _context.customers.Add(customer);
        //        await _context.SaveChangesAsync();

        //        return CreatedAtAction("GetCustomer", new { id = customer.id }, customer);
        //    }

        //    // DELETE: api/Customers/5
        //    [HttpDelete("{id}")]
        //    public async Task<IActionResult> DeleteCustomer(int id)
        //    {
        //        var customer = await _context.customers.FindAsync(id);
        //        if (customer == null)
        //        {
        //            return NotFound();
        //        }

        //        _context.customers.Remove(customer);
        //        await _context.SaveChangesAsync();

        //        return NoContent();
        //    }

        //    private bool CustomerExists(int id)
        //    {
        //        return _context.customers.Any(e => e.id == id);
        //    }
    }
}
