using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Froms_In_dot_net
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cvTerms_ServerValidate(object source,

            ServerValidateEventArgs args)

        {

            args.IsValid = chkTerms.Checked;

        }



        protected void btnRegister_Click(object sender, EventArgs e)

        {

            if (Page.IsValid)

            {

                lblDisplay.Text = "Registration Successful!";

            }

        }
    }
}