using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository : IRepositoryGenerics<PersonPhone>
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();
        Task Remove(int phoneNumberTypeID, int businessEntityID);
    }
}
