using Application.Core;
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
        public class Command : IRequest<Result<Unit>>
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
        public class Handler : IRequestHandler<Command,Result<Unit>>
        {
            private readonly TimelyContext _context;
 
            public Handler(TimelyContext context,IMapper mapper)
            {
                _context = context;
   
            }
            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.Projects.Add(request.Project); 
                var result=await _context.SaveChangesAsync()>0;
                if (!result) return Result<Unit>.Failure("Failed to create Project");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}
