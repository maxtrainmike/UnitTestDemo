using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo
{
    static public class BusinessFunctions
    {
        static public string GetStateName(string code)
        {
            //// Plan 1: Nested IFs
            if (code == "OH")
            {
                return "Ohio";
            }
            else if (code == "IN")
            {
                return "Indiana";
            }
            else if (code == "KY")
            {
                return "Kentucky";
            }
            else
                return "";



            //// Plan 2: SWITCH
            //string name;

            //switch (code)
            //{
            //    case "OH": { name = "Ohio"; break; }
            //    case "IN": { name = "Indiana"; break; }
            //    case "KY": { name = "Kentucky"; break; }
            //    default:  { name = ""; break; }
            //}
            //return name;


            //// Plan 3: Dictionary
            //Dictionary<string,string> stateList= new Dictionary<string,string>();
            //stateList.Add("OH", "Ohio");
            //stateList.Add("IN", "Indiana");
            //stateList.Add("KY", "Kentucky");

            //string name = "";
            //stateList.TryGetValue(code, out name);
            //return name;


            //// Plan 4: SQL Table
            //// Need Microsoft.Data.SqlClient
            //Dictionary<string,string> stateList= new Dictionary<string,string>();

            //string conString = "";
            //string sqlCommand = "SELECT StateCode,StateName FROM States";

            //using (SqlConnection conn = new SqlConnection(conString))
            //{
            //    conn.Open();

            //    using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
            //    {
            //        //Console.WriteLine("Sending SQL command...");
            //        SqlDataReader dr = cmd.ExecuteReader();
            //        //Console.WriteLine("Reading data...");
            //        while (dr.Read())
            //        {
            //            stateList.Add(dr["StateCode"].ToString(), dr["StateName"].ToString());
            //        }
            //    }
            //}

            //string name = "";
            //stateList.TryGetValue(code, out name);
            //return name;

        }
    }
}
