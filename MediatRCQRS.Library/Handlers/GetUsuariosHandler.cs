using MediatR;
using MediatRCQRS.Library.Data;
using MediatRCQRS.Library.Models;
using MediatRCQRS.Library.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Library.Handlers
{
    public class GetUsuariosHandler : IRequestHandler<GetUsuariosListQueries, List<Usuarios>>
    {
        private readonly ApplicationDbContext context;

        public GetUsuariosHandler(ApplicationDbContext _context)
        {
          context = _context;
        }

        public async Task<List<Usuarios>> Handle(GetUsuariosListQueries request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(context.Usuarios.ToList());
        }
    }
}
