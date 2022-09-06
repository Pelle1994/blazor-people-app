using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Interfaces;
using DataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace DataAccessLibrary.Data
{
    public class PeopleService : IPeopleService
    {
        private readonly IDbContextFactory<PeopleContext> _fact;

        public PeopleService(IDbContextFactory<PeopleContext> fact)
        {
            _fact = fact;
        }
        public async Task<IList<Person>> GetAll()
        {
            var context = await _fact.CreateDbContextAsync();
            
            return await context.Set<Person>().ToListAsync();

        }

        public async Task AddPerson(Person person)
        {
            var context = await _fact.CreateDbContextAsync();

            await context.Set<Person>().AddAsync(person);

            await context.SaveChangesAsync();
        }
    }

  
}
