using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class UpdatePanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Label1.Text = now.ToLongTimeString();
            Label2.Text = now.ToLongTimeString();
        }
    }
}