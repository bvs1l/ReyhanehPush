using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace BouloutDbApp
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString=
            @"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\DataBaseBoulout.accdb;";
        //@"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\BouloutDb.accdb;";


        // Update the connection string as per your database configuration


    }
}
