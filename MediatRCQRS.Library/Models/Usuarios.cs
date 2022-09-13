using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatRCQRS.Library.Models
{
    public class Usuarios
    {

        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Cargo { get; set; }

        public int Salario { get; set; }
    }
}
