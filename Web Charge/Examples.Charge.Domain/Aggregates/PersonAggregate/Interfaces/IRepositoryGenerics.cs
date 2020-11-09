using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IRepositoryGenerics<T> where T: class
    {
        Task SaveAsync(T objeto);
        Task UpdateAsync(T objeto);
        Task RemoveAsync(int id);
    }
}
