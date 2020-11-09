using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;

        }

        public Task Add(PersonPhone objeto)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Person>> FindAllAsync() => (await _personRepository.FindAllAsync()).ToList();

        public Task Remove(PersonPhone objeto)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(PersonPhone objeto)
        {
            throw new System.NotImplementedException();
        }
    }
}
