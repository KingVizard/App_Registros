using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using App_Registros.Models;
using System.Threading.Tasks;
using App_Registros.Data;


namespace App_Registros.Data
{
 //   internal class SQLiteHelper
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;

        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Empleados>().Wait();
        }

        public Task<int> SaveEmpleadoAsync(Empleados emple) 
        { 
            if(emple.IdEmp == 0)
            {
                return db.InsertAsync(emple);
            } else
            {
                return null;
            }
        }

        public Task<List<Empleados>>GetEmpleadosAsync() 
        {
            return db.Table<Empleados>().ToListAsync();
        }
    }
}
