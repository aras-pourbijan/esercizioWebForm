using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace esercizioWebForm
{
    public partial class addDipendente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    SqlConnection conessione = new SqlConnection();
                try
                {
                    conessione.ConnectionString= ConfigurationManager.ConnectionStrings["edilMan"].ToString();
                    conessione.Open();
                    SqlCommand commando= conessione.CreateCommand();
                    commando.CommandType = System.Data.CommandType.StoredProcedure;
                    commando.CommandText = "insertDipendente";
                    commando.Parameters.AddWithValue("nome", txtNome.Text);
                    commando.Parameters.AddWithValue("Cognome", txtCognome.Text);
                    commando.Parameters.AddWithValue("indirizzo", TXTINDIRIZZO.Text);
                    commando.Parameters.AddWithValue("CF", Textcf.Text);
                    commando.Parameters.AddWithValue("coniugato", CheckBox1.Checked);
                    commando.Parameters.AddWithValue("figli", Textfigli.Text);
                    commando.Parameters.AddWithValue("mansione", Textmansione.Text);
                    int row = commando.ExecuteNonQuery();
                    if (row > 0)
                    {
                        Response.Redirect("home.aspx");
                    }
                }
                catch(Exception ex)
                {
                    Label1.Text = $"Errore:{ex}";
                    Label1.Visible = true;
                }
                finally
                {
                    conessione.Close();
                }
            }
        }
    }
}