using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IgraonicaVebProgramiranje_StefanAndrejevic
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_login_Click(object sender, EventArgs e)
        {
            Konekcija cs = new Konekcija();
            if (cs.ProveraKorisnika(txt_email.Text, txt_lozinka.Text) == 0)
            {
                Response.Redirect("Testiranje.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void btn_register_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}