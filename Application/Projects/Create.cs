using AutoMapper;
using Domain.Entities;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects
{
    public class Create
    {
        public class Command : IRequest
        {
            public Project Project { get; set; }    
        }
        public class CommandValidetor : AbstractValidator<Command>
        {
            public CommandValidetor()
            {
                RuleFor(X => X.Project).SetValidator(new ProjectValidator());
            }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly TimelyContext _context;
            private readonly IMapper _mapper;
            public Handler(TimelyContext context,IMapper mapper)
            {
                _context = context;
                _mapper = mapper;   
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Projects.Add(request.Project); 
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}
