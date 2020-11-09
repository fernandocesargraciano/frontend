using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() 
        {
            return await _personPhoneRepository.FindAllAsync();
        }

        public async Task Add(PersonPhone objeto)
        {
            await _personPhoneRepository.SaveAsync(objeto);
        }

        public async Task Update(PersonPhone objeto)
        {
            await _personPhoneRepository.UpdateAsync(objeto);
        }

        public async Task Remove(int phoneNumberTypeID, int businessEntityID)
        {
            await _personPhoneRepository.Remove(phoneNumberTypeID, businessEntityID);
        }

       
    }
}
