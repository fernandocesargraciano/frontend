using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneService 
    {
        Task<IEnumerable<PersonPhone>> FindAllAsync();
        Task Add(PersonPhone objeto);
        Task Update(PersonPhone objeto);
        Task Remove(int phoneNumberTypeID, int businessEntityID);
    }
}
