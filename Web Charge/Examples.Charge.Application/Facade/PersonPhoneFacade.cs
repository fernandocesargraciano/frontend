using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private IPersonPhoneFacade _personPhoneService;
        private IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneFacade personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonPhoneResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneResponse();
            response.ListAll = new List<PersonPhoneDto>();
            return response;
        }
    

    }
}
