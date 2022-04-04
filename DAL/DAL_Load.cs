using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace DAL
{
    public class DAL_Load
    {
        public static DataTable SelectSQL(string _SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                String DB_Path = @"Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "EmployeeDB.db") + "; Version=3;New=False;Compress=True;";
                SQLiteConnection conn = new SQLiteConnection(DB_Path);
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = _SQL;
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
            }
            catch { 
           
            }
            return dt;
        } 


        public static int ExecuteSQL(string _SQL)
        {
            int Result = new int();
            try
            {
                String DB_Path = @"Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "EmployeeDB.db") + "; Version=3;New=False;Compress=True;";
                SQLiteConnection conn = new SQLiteConnection(DB_Path);
                conn.Open();
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = _SQL;
                Result = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {

            }
            return Result;
        }

    }

}
