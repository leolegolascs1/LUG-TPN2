﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Abstraccion
{
   public interface IGestor<T> where T: IEntidad
    {
        bool Guardar(T Objeto);
        //bool Guardars(T Objeto);
        bool Baja(T Objeto);
        List<T> ListarTodo();
        //List<T> ListarTodo2();
     //   DataTable ListarTodoTable();
     //   T ListarObjeto(T Objeto);
    }
}
