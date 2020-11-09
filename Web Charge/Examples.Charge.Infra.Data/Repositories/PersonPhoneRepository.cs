using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository 
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public async  Task Remove(int phoneNumberTypeID, int businessEntityID)
        {
            var item = _context.PersonPhone.Where(a => a.BusinessEntityID == businessEntityID && a.PhoneNumberTypeID == phoneNumberTypeID).FirstOrDefault();
            _context.PersonPhone.Remove(item);
            await _context.SaveChangesAsync();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(PersonPhone objeto)
        {
            _context.PersonPhone.Add(objeto);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(PersonPhone objeto)
        {
            _context.PersonPhone.Update(objeto);
            await _context.SaveChangesAsync();
        }

        
    }
}
