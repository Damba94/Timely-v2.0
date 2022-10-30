using Domain.Entities;
using Domain;
using Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Projects
{
    public class List
    {
        public class Query: IRequest<List<Project>> { }

         public class Handler : IRequestHandler<Query, List<Project>>
         {
             private readonly TimelyContext _context;
             public Handler(TimelyContext context)
             {
                 _context = context;
             }
             public async Task<List<Project>> Handle(Query request, CancellationToken cancellationToken)
             {
                return await _context.Projects.ToListAsync(cancellationToken);
             }
         }
    }
}
