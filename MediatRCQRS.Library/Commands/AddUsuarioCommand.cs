using MediatR;
using MediatRCQRS.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Library.Commands
{
    //Command Crear
    public record AddUsuarioCommand(Usuarios usuario): IRequest<Usuarios>;
}
