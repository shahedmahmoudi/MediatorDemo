using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler:IRequestHandler<GetPersonByIdQuery,PesonModel>
    {
        private readonly IMediator _mediator;
        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<PesonModel> Handle(GetPersonByIdQuery request,CancellationToken canclelationToken)
        {
            var result = await _mediator.Send(new GetPersonListQuery());
            var output = result.FirstOrDefault(x => x.Id == request.Id);
            return output;
        }
    }
}
