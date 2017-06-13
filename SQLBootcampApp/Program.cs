using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLBootcampApp
{
    class Program
    {
        private static string myConnectionString = "server=localhost;database=battlerecord;uid=root;pwd=KR19tr222013;";
        static void Main(string[] args)
        {
            MySqlConnection cnn;
            cnn = new MySqlConnection(myConnectionString);
            try
            {
                cnn.Open();
                Console.WriteLine("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection ! ");
            }

            Console.ReadLine();
        }
    }
}
