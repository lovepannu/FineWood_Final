﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FurnitureStoreFinal.Models
{
    public class AdminDB
    {
        public int id { get; set; }

        
        public String Sname { get; set; }
        public String Spassword { get; set; }

        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=FurnitureStore;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        // this code is used to in the details of a prticuar query from the table using the sql statement with the help of where clause 
        public DataTable chkkLogin(String query)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(query, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();

            return tbl;

        }



    }
}