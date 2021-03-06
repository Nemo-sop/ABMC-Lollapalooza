using gestorLollapalooza.bussinesLayer;
using gestorLollapalooza.dataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestorLollapalooza.Service
{
    class FestivalService
    {
        private FestivalDao dao = new FestivalDao();
        public IList<Festival> obtenerTodos()
        {
            return dao.obtenerTodos();
        }

        public bool borradoLogicamente(int idFestival)
        {
            return dao.borradoLogicamente(idFestival);
        }

        public bool modificarFestival(Festival festival)
        {
            return dao.modificarFestival(festival);
        }

        public bool persistirFestival(Festival festival)
        {
            return dao.persistirFestival(festival);
        }

        public DataTable recuperarFiltadrosDT(string filtros)
        {
            return dao.recuperarFiltradosDT(filtros);
        }

        public IList<Festival> recuperarFiltrados(string filtros)
        {
            return dao.recuperarFiltrados(filtros);
        }


        public Festival MapearFestival(DataRow row)
        {
            return dao.MapearFestival(row);
        }

        public DataTable obtenerTodosDt()
        {
            return dao.obtenerTodosDt();
        }
    }
}
