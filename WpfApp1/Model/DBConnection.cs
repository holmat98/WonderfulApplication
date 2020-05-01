using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows;

namespace WpfApp1.Model
{
    class DBConnection
    {
        public SQLiteConnection Connection { get; set; }

        public DBConnection()
        {
            try
            {
                Connection = new SQLiteConnection(@"Data source = ../../DataBaseFile/fiszki.db");
                Connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Nie połączono z bazą!!!\n" + e);
            }
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
