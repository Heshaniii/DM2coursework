﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DM2coursework
{
    public static class Database
    {
        public static OracleConnection GetConnection()
        {
            string connString = "User Id=system;Password=12345;Data Source=localhost:1521/XE;";
            return new OracleConnection(connString);
        }
    }
}
