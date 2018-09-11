using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo9112018.Model
{
    class Ciudad
    {

        int id;
        Nacionalidad nacionalidad;
        String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal Nacionalidad Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }
}
