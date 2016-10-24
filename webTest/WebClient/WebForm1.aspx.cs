using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string select = DropDownList1.SelectedValue;
            string firstname = TextBox1.Text;
            string lastname = TextBox2.Text;
            string email = TextBox3.Text;

            LabelResult.Text = String.Format("{0} {1} select the event {2}", firstname, lastname, select);
        }
    }
}