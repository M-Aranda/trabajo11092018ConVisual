using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo9112018.Model
{
    class DAO_Ciudad : Conexion, IDAO<Ciudad>
    {

        public DAO_Ciudad() : base("trabajo11092018")
        {

        }

        public DataTable BuscarPorRun(string run)
        {
            return null;
        }

        public void Create(Ciudad ob)
        {
            Ejecutar("INSERT INTO ciudad VALUES("+ob.Nacionalidad.Id+",'"+ob.Nombre+"')");
        }

        public void Delete(int id)
        {

            Ejecutar("DELETE FROM ciudad WHERE id="+id+"");
        }

        public DataTable Read()
        {
            return Ejecutar("SELECT * FROM ciudad ORDER BY nombre DESC");
            
        }

        public void Update(Ciudad ob)
        {
            Ejecutar("UPDATE ciudad SET fk_nacionalidad=" + ob.Nacionalidad.Id + " nombre='" + ob.Nombre + "'");
        }
    }
}
