using DemoLibrary.Commands;
using DemoLibrary.DataAcsess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PesonModel>
    {
        private readonly IDataAccsess _data;
        public InsertPersonHandler(IDataAccsess data)
        {
            _data = data;
        }
        public Task<PesonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertPeople(request.firstName, request.lastName));
        }

    }
}
