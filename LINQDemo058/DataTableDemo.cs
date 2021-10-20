using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo058
{
    //UC8 Create DataTable
    class DataTableDemo
    {
        public static void CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ProductID");
            table.Columns.Add("UserID");
            table.Columns.Add("Review");
            table.Columns.Add("Rating");
            table.Columns.Add("IsLike");

            table.Rows.Add("1", "1", "Good", "17", "true");
            table.Rows.Add("2", "3", "bad", "8", "False");
            table.Rows.Add("1", "4", "nice", "13", "true");
            table.Rows.Add("3", "6", "Good", "19", "true");
            table.Rows.Add("5", "4", "bad", "2", "False");
            table.Rows.Add("5", "5", "nice", "14", "true");
            table.Rows.Add("8", "7", "Good", "18", "true");
            table.Rows.Add("9", "1", "Good", "16", "true");
            table.Rows.Add("7", "8", "bad", "1", "False");
            table.Rows.Add("6", "8", "bad", "5", "False");
            table.Rows.Add("2", "9", "Good", "16", "true");
            table.Rows.Add("6", "2", "Good", "15", "true");
            table.Rows.Add("9", "4", "bad", "2", "False");
            table.Rows.Add("8", "1", "Good", "17", "true");
            table.Rows.Add("2", "5", "Good", "18", "true");
            table.Rows.Add("4", "3", "bad", "4", "False"); 
            table.Rows.Add("5", "3", "Good", "17", "true");
            table.Rows.Add("3", "14", "Good","19", "true");
            table.Rows.Add("2", "6", "bad", "2", "False");
            table.Rows.Add("6", "1", "nice", "14", "true");
            table.Rows.Add("7", "4", "Good", "18", "true");
            table.Rows.Add("1", "1", "Good", "17", "true");
            table.Rows.Add("9", "9", "bad", "1", "False");
            table.Rows.Add("8", "8", "Good", "19", "true");
            table.Rows.Add("4", "7", "bad", "8", "False");
            DisplayData(table);
            //RetriveDataIsTrue(table);
        }
        public static void DisplayData(DataTable table)
        {

            IEnumerable<DataRow> query = from dt in table.AsEnumerable() select dt;
            //Get all the values from datatble

            foreach (DataRow dr in query)
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine(dr.Field<string>("ProductID")+("\t")+ dr.Field<string>("UserID")+ ("\t") + dr.Field<string>("Review")+ ("\t") + dr.Field<string>("Rating")+ ("\t") + dr.Field<string>("IsLike"));
            }
        }
    }
}
