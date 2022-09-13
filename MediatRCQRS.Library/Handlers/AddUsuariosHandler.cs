using MediatR;
using MediatRCQRS.Library.Commands;
using MediatRCQRS.Library.Data;
using MediatRCQRS.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Library.Handlers
{
    public class AddUsuariosHandler : IRequestHandler<AddUsuarioCommand, Usuarios>
    {
        private readonly ApplicationDbContext context;

        public AddUsuariosHandler(ApplicationDbContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Handle(AddUsuarioCommand request, CancellationToken cancellationToken)
        {
            context.Usuarios.Add(request.usuario);
            context.SaveChangesAsync();

            return await Task.FromResult(request.usuario);
        }
    }
}
