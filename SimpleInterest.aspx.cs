using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Froms_In_dot_net
{
    public partial class SimpleInterest : System.Web.UI.Page
    {
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(txtPrincipal.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double time = Convert.ToDouble(txtTime.Text);

            double si = (principal * rate * time) / 100;
            lblResult.Text = "Simple Interest = " + si.ToString("F2");
        }
    }
}