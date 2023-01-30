using Examen_TercerProgreso.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_TercerProgreso.Database
{
    public class DatabaseDetector_NH
    {
        string _dbPath;
        private SQLiteConnection conn;

        //public DatabaseActions(string DatabasePath)
        //{
        //    _dbPath = DatabasePath;
        //    return;
        //}

        private void Init()
        {
            if (conn != null)                            
                return;
            conn = new SQLiteConnection(_dbPath);        
            conn.CreateTable<DetectorModel>();                
        }
    }
}
