using AutoMapper;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using System.Collections.Generic;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneService _service;
        

        public PersonPhoneController(IPersonPhoneService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<PersonPhone>> Get()
        {
            return await _service.FindAllAsync();
        }

       [HttpPost]
       public async Task Post([FromBody] PersonPhone objeto)
        {
            await _service.Add(objeto);
        }

        [HttpPost]
        public async Task Put([FromBody] PersonPhone objeto)
        {
            await _service.Update(objeto);
        }

        [HttpDelete("{phoneNumberTypeID}/{businessEntityID}")]
        public async Task Delete(int phoneNumberTypeID, int businessEntityID)
        {
            await _service.Remove(phoneNumberTypeID, businessEntityID);
        }

    }
}
