using System;
using System.Data;
using DAL;

namespace BLL
{
    public class BLL_Load
    {
        public static DataTable SelectToDataGrid()
        {
            DataTable dt = new DataTable();
            dt = DAL_Load.SelectSQL("SELECT \r\n" +
                            "ROW_NUMBER() OVER(ORDER BY EmployeeID ASC) AS 'No.', \r\n" +
                            "Employees.EmployeeID, \r\n" +
                            "Employees.Name, \r\n" +
                            "Employees.Surname, \r\n" +
                            "Employees.Birthday,  \r\n" +
                            "MasterGender.GenderName, \r\n" +
                            "MasterPosition.PositionName \r\n" +
                            "FROM \r\n" +
                            "Employees \r\n" +
                            "LEFT JOIN MasterGender   ON  Employees.GenderID = MasterGender.GenderID \r\n" +
                            "LEFT JOIN MasterPosition   ON  Employees.PositionID = MasterPosition.PositionID \r\n" +
                            "ORDER BY Employees.EmployeeID ASC");
            return dt;

        }
        public static DataTable SelectToEdit(string _ID)
        {
            DataTable dt = new DataTable();
            dt = DAL_Load.SelectSQL("SELECT \r\n" +
                            "Employees.EmployeeID, \r\n" +
                            "Employees.Name, \r\n" +
                            "Employees.Surname, \r\n" +
                            "Employees.Birthday, \r\n" +
                            "Employees.GenderID, \r\n" +
                            "Employees.PositionID \r\n" +
                            "FROM \r\n" +
                            "Employees \r\n" +
                            "WHERE Employees.EmployeeID = '" + _ID + "' \r\n" +
                            "ORDER BY Employees.EmployeeID ASC");
            return dt;

        }
        public static int InsertToDB(string _Name, string _Surname, string _Birthday, int _Gender, int _Position)
        {
            int Result = new int();
            Result = DAL_Load.ExecuteSQL("INSERT INTO Employees(Name, Surname, Birthday, GenderID, PositionID)  \r\n" +
                                "VALUES('" + _Name + "', '" + _Surname + "', '" + _Birthday + "', '" + _Gender + "', '" + _Position + "')");
            return Result;
        }
        public static int UpdateToDB(string _Name, string _Surname, string _Birthday, int _Gender, int _Position, string _ID)
        {
            int Result = new int();
            Result = DAL_Load.ExecuteSQL("UPDATE Employees \r\n" +
                                            "SET Name = '" + _Name + "', \r\n" +
                                                "Surname = '" + _Surname + "', \r\n" +
                                                "Birthday = '" + _Birthday + "', \r\n" +
                                                "GenderID = '" + _Gender + "',  \r\n" +
                                                "PositionID = '" + _Position + "' \r\n" +
                                            "WHERE EmployeeID = '" + _ID + "'");
            return Result;
        }
        public static int DeletesFromDB(string _ID)
        {
            int Result = new int();
            Result = DAL_Load.ExecuteSQL("DELETE FROM Employees WHERE EmployeeID ='" + _ID + "'");
            return Result;
        }



    }
}
