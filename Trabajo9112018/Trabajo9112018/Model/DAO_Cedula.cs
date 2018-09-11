using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo9112018.Model
{
    class DAO_Cedula : Conexion, IDAO<Cedula>
    {
        public DAO_Cedula() : base("trabajo11092018")
        {
        }

        public DataTable BuscarPorRun(string run)
        {
            return Ejecutar("SELECT * FROM cedula WHERE run='"+run+"'");
        }

        public void Create(Cedula ob)
        {
            Ejecutar("INSERT INTO cedul aapellidos, nombres,fk_nacionalidad, sexo, fechaDeNacimiento, numeroDeDocumento, " +
                "fechaDeEmision, fechaDeVencimiento, run, fk_ciudadDeNacimiento, profesion, rutaFoto) VALUES('"+ob.Apellidos+"'," +
                "'"+ob.Nombres+"',"+ob.Nacionalidad.Id+", '"+ob.Sexo+"', '"+ob.FechaDeNacimiento+"','"+ob.NumeroDeDocumento+"','"+ob.FechaDeEmision+"" +
                "', '"+ob.FechaDeEmision+"', '"+ob.FechaDeVencimiento+"', '"+ob.Run+"', "+ob.CiudadDeNacimiento+", '"+ob.Profesion+"'," +
                "'"+ob.RutaDeFoto+"')");
        }

        public void Delete(int id)
        {
            Ejecutar("DELETE FROM cedula WHERE id="+id+"");
        }

        public DataTable Read()
        {
            return Ejecutar("SELECT * FROM verDatosDeCedula");
        }

        public void Update(Cedula ob)
        {
            Ejecutar("UPDATE cedula SET apellidos='"+ob.Apellidos+"', nombres='"+ob.Nombres+"', fk_nacionalidad="+ob.Nacionalidad.Id+"," +
                "sexo="+ob.Sexo+", fechaDeNacimiento='"+ob.FechaDeNacimiento+"', numeroDeDocumento='"+ob.NumeroDeDocumento+"'," +
                "fechaDeEmision='"+ob.FechaDeEmision+"', fechaDeVencimiento='"+ob.FechaDeVencimiento+"', run='"+ob.Run+"', " +
                "fk_ciudadDeNacimiento="+ob.CiudadDeNacimiento.Id+", profesion='"+ob.Profesion+"', rutaFoto='"+ob.RutaDeFoto+"'");
        }
    }
}
