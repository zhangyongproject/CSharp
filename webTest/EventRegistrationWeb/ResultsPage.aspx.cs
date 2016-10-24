using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventRegistrationWeb
{
    public partial class ResultsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList dropDownListEvents = (DropDownList)PreviousPage.FindControl("dropDownListEvent");
            string selectedEvent    = dropDownListEvents.SelectedValue;
            string firstName        = ((TextBox)PreviousPage.FindControl("textFirstName")).Text;
            string lastName         = ((TextBox)PreviousPage.FindControl("textLastName")).Text;
            string email            = ((TextBox)PreviousPage.FindControl("textEmail")).Text;

            labelResult.Text = String.Format("{0} {1} selected the event {2}",
            firstName, lastName, selectedEvent);
        }
    }
}