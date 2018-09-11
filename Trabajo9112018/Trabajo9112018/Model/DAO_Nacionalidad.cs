using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo9112018.Model
{
    class DAO_Nacionalidad : Conexion, IDAO<Nacionalidad>
    {

        public DAO_Nacionalidad() : base("trabajo11092018")
        {
        }

        public DataTable BuscarPorRun(string run)
        {
            return null;
        }

        public void Create(Nacionalidad ob)
        {
            Ejecutar("INSERT INTO nacionalidad VALUES ('"+ob.Nombre+"')");
        }

        public void Delete(int id)
        {
            Ejecutar("DELETE FROM nacionalidad WHERE id="+id+"");
        }

        public DataTable Read()
        {
            return Ejecutar("SELECT * FROM nacionalidad ORDER BY nombre DESC");
        }

        public void Update(Nacionalidad ob)
        {
            Ejecutar("UPDATE nacionalidad SET nombre='"+ob.Nombre+"' WHERE id="+ob.Id+"");
        }
    }
}
