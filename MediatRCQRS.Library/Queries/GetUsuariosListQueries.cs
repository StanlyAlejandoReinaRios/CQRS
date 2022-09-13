using MediatR;
using MediatRCQRS.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Library.Queries
{
    //Query obtener los usuarios
    public record GetUsuariosListQueries() : IRequest<List<Usuarios>>;
}
