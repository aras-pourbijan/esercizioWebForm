using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace esercizioWebForm.Models
{
    public class dipendente
    {

        public int IDdipendnete { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CF { get; set; }
        public bool coniugato { get; set; }
        public int figli { get; set; }
        public string Mansione { get; set; }

        public void insertDipendente()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["edilMan"].ToString();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "insertDipendente";
        }

        public void insertMansione()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["edilMan"].ToString();
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = "insert into mansione values ('stagista')";
            command.Connection = connection;
            int row = command.ExecuteNonQuery();
            if (row > 0)
            {

            }
            else
            {

            }
        }
        public string statoMatrimonio { get; set; }

    }
}
