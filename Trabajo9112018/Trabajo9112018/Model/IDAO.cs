using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Trabajo9112018.Model
{
    interface IDAO<T>
    {
        void Create(T ob);
        DataTable Read();
        void Update(T ob);
        void Delete(int id);

        DataTable BuscarPorRun(String run);


    }
}
