using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/Person
        [HttpGet]
        public async Task<List<PesonModel>> Get()
        {
            return await _mediator.Send(new GetPersonListQuery());
        }

        // GET: api/Person/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<PesonModel> Get(int id)
        {
            return await _mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST: api/Person
        [HttpPost]
        public async Task<PesonModel> Post([FromBody] PesonModel value)
        {
            var model = new InsertPersonCommand(value.firstName, value.lastName);
            return await _mediator.Send(model);
        }

        // PUT: api/Person/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
