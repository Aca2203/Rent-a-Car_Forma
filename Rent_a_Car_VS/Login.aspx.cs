using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rent_a_Car_VS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Rent_a_Car klasa = new Rent_a_Car();
            int rezultat;
            rezultat = klasa.Provera_Korisnika(txt_email.Text, txt_lozinka.Text);

            if (rezultat == 0)
            {
                Session["korisnik"] = txt_email.Text;
                Response.Redirect("kontrolpanel.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}