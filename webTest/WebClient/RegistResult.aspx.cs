using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class RegistResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DropDownList dropDownListEvents = 
            (DropDownList)PreviousPage.FindControl("DropDownList1");

                string select = dropDownListEvents.SelectedValue;
                string firstname = ((TextBox)PreviousPage.FindControl("TextBox1")).Text;
                string lastname = ((TextBox)PreviousPage.FindControl("TextBox2")).Text;
                string email = ((TextBox)PreviousPage.FindControl("TextBox3")).Text;

                LabelResult.Text = String.Format("{0} {1} select the event {2}", firstname, lastname, select);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}