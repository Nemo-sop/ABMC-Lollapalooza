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
    class PuntoVentaService
    {
        private PuntoVentaDao puntoVentaObj;

        public PuntoVentaService()
        {
            this.puntoVentaObj = new PuntoVentaDao();
        }

        public bool borrarLogicamente(string nombre)
        {
            // Metodo encargado de darle borrar de forma logica un usuario, recibe como parametro:
            // * string NombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo borradoLogicamente()
            // Si se consigue borrar el usuario se retorna true
            // en caso contrario retorna false

            return (this.puntoVentaObj.borradoLogicamente(nombre));
        }


        public IList<PuntoVenta> RecuperarTodos()
        {
            // Metodo encargado de recuperar todos los usuarios de la base de datos, no recibe parametros
            // utiliza al usuarioDao para que realice la tarea mediante el metodo obtenerTodos()
            // Si se logra recuperar todos los usuarios retorna una lista de usuarios 

            IList<PuntoVenta> puntoVentas = puntoVentaObj.obtenerTodos();
            return puntoVentas;

        }

        public IList<PuntoVenta> obtenerFiltados(string filtros)
        {
            // Metodo encargado de buscar usuarios en la bd en base a filtros, recibe como parametros:
            // * string filtros
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarFiltrados()
            // si encuentra usuarios en base al filtro retorna una lista de usuarios

            return puntoVentaObj.recuperarFiltrados(filtros);
        }

        public bool PersistirPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado de persistir un usuario, recibe como parametro:
            // * Usuario usuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo persistirUsuario()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return puntoVentaObj.persistirPuntoVenta(puntoVenta);
        }

        public PuntoVenta recuperarPuntoVenta(string nombre)
        {
            // Metodo encargado de traer un usuario de la bd, recibe como parametro:
            // * String nombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarUsuario()
            // Si se logra recupear al usuario  retorna un usuario

            return puntoVentaObj.recuperarPuntoVenta(nombre);
        }

        public bool ExistePuntoVenta(string nombre)
        {
            // Metodo encargado de comprobar si un usuario se encuentra en la bd, recibe como parametro:
            // * String nombreUsuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo recuperarUsuario()
            // Si se el usuario se encuentra en la bd retorna true en caso contrario retorna false

            return (puntoVentaObj.recuperarPuntoVenta(nombre) != null);
        }


        public bool modificarPuntoVenta(PuntoVenta puntoVenta)
        {
            // Metodo encargado de modificar un usuario, recibe como parametro:
            // * Usuario usuario
            // utiliza al usuarioDao para que realice la tarea mediante el metodo modificarUsuario()
            // Si se logra modificar retorna true en caso contrario retorna false 

            return this.puntoVentaObj.modificarPuntoVenta(puntoVenta);
        }

        public IList<PuntoVenta> recuperarDeCentro (int idCentro)
        {
            return this.puntoVentaObj.obtenerTodosDeUnCentro(idCentro);
        }

        public IList<PuntoVenta> recuperarDeCentroListados(int idCentro)
        {
            return this.puntoVentaObj.obtenerTodosDeUnCentroListados(idCentro);
        }
    }
}
