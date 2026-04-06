using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IgraonicaVebProgramiranje_StefanAndrejevic
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_register_Click(object sender,EventArgs e)
        {
            Konekcija cs = new Konekcija();
            if (cs.UnosKorisnika(txt_ime.Text, txt_email.Text, txt_lozinka.Text) == 0)
            {
                Response.Redirect("Login.aspx");
            }
            else { Response.Redirect("Register.aspx"); }
        }
    }
}