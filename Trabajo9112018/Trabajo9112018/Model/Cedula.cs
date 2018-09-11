using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo9112018.Model
{
    class Cedula
    {

        int id;
        String apellidos;
        String nombres;
        Nacionalidad nacionalidad;
        String sexo;
        DateTime fechaDeNacimiento;
        String numeroDeDocumento;
        DateTime fechaDeEmision;
        DateTime fechaDeVencimiento;
        String run;
        Ciudad ciudadDeNacimiento;
        String profesion;
        String rutaDeFoto;

        public int Id { get => id; set => id = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public DateTime FechaDeNacimiento { get => fechaDeNacimiento; set => fechaDeNacimiento = value; }
        public string NumeroDeDocumento { get => numeroDeDocumento; set => numeroDeDocumento = value; }
        public DateTime FechaDeEmision { get => fechaDeEmision; set => fechaDeEmision = value; }
        public DateTime FechaDeVencimiento { get => fechaDeVencimiento; set => fechaDeVencimiento = value; }
        public string Run { get => run; set => run = value; }
        public string Profesion { get => profesion; set => profesion = value; }
        public string RutaDeFoto { get => rutaDeFoto; set => rutaDeFoto = value; }
        internal Nacionalidad Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        internal Ciudad CiudadDeNacimiento { get => ciudadDeNacimiento; set => ciudadDeNacimiento = value; }
    }
}
