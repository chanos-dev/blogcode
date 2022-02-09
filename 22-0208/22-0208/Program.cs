using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_0208
{
    class Program
    {
        static void Main(string[] args)
        {
            var helper = new SQLiteHelper();
            var testDB1 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test1.db");
            var testDB2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "test2.db");
            helper.DateBaseInit(testDB1, "1", "test1");
            helper.DateBaseInit(testDB2, "2", "test2");
            helper.Merge(testDB1, testDB2);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }

    internal class SQLiteHelper
    {
        private const string TEST_TABLE = @"
    CREATE TABLE TEST (
    test_key INTEGER   PRIMARY KEY,
    title    CHAR (32));
";
        public SQLiteHelper()
        {

        }

        private string GetConnectionString(string path) => $"Data Source={path};";

        internal void DateBaseInit(string absolutePath, string data1, string data2)
        {
            CreateDataBase(absolutePath);
            InsertTestData(absolutePath, data1, data2);
        }

        private void CreateDataBase(string absolutePath)
        { 
            var connString = GetConnectionString(absolutePath);
            using (var conn = new SQLiteConnection(connString))
            {                
                conn.Open();
                ExeucteNonQuery(conn, TEST_TABLE);
            }
        }         

        private void InsertTestData(string absolutePath, string data1, string data2)
        {
            var connString = GetConnectionString(absolutePath);
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                ExeucteNonQuery(conn, $"insert into TEST (test_key, title) values ({data1}, '{data2}')");
            }
        }

        internal void Merge(string sourcePath, string targetPath)
        {
            // backup target
            File.Copy(targetPath, Path.ChangeExtension(targetPath, ".bak"), true);

            var connString = GetConnectionString(targetPath);
            using (var conn = new SQLiteConnection(connString))
            {
                conn.Open();
                ExeucteNonQuery(conn, $@"attach '{sourcePath}' as source");
                ExeucteNonQuery(conn, "insert or replace into test select * from source.test"); 
            }
        }

        private void ExeucteNonQuery(SQLiteConnection conn, string query)
        {
            using (var command = conn.CreateCommand())
            {
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
        }
    }
}
