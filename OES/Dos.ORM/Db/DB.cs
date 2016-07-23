using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dos.ORM.Db
{
        public class DB
        {
            public static readonly DbSession Context = new DbSession("JiangNanConn");

            public static bool AddEntity<T>(T entity) where T : Entity
            {
                return Context.Insert(entity) > 0;
            }
        }


   
}
