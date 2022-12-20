using esercizioWebForm.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace esercizioWebForm
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

                SqlConnection connection = new SqlConnection();
            try
            {

                connection.ConnectionString = ConfigurationManager.ConnectionStrings["edilMan"].ToString();
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "select IDdipendente, nome, cognome, indirizzo, codicefiscale, coniugato, figli, nomemansione from dipendente join mansione on dipendente.IDmansione=mansione.IDmansione";
                command.Connection = connection;
                SqlDataReader Reader = command.ExecuteReader();

                List<dipendente> ListaDipendenti = new List<dipendente>();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        dipendente D = new dipendente();
                        D.IDdipendnete = Convert.ToInt32(Reader["IDdipendente"]);
                        D.Nome = Reader["nome"].ToString();
                        D.Cognome = Reader["Cognome"].ToString();
                        D.Indirizzo = Reader["Indirizzo"].ToString();
                        D.CF = Reader["CodiceFiscale"].ToString();
                        D.coniugato = Reader["coniugato"].Equals(true);
                        if (D.coniugato)
                        {
                            D.statoMatrimonio = "sposato";
                        }
                        else
                        {
                            D.statoMatrimonio = "single";
                        }
                        D.figli = Convert.ToInt32(Reader["figli"]);
                        D.Mansione = Reader["nomemansione"].ToString();
                        ListaDipendenti.Add(D);

                    }

                    RepeaterListaDipendenti.DataSource = ListaDipendenti;
                    RepeaterListaDipendenti.DataBind();

                }
               
            }
            catch (Exception ex)
            {
                LabelErr.Text = ex.Message;

            }
            finally
            {
                connection.Close();
            }
        }
    }
}