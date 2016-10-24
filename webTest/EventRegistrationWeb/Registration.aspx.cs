using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventRegistrationWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonSubmit_Click(object sender, EventArgs e)
        {
            string selectedEvent = dropDownListEvent.SelectedValue;
            string firstname        = textFirstName.Text;
            string lastname = textLastName.Text;
            string email = textEmail.Text;
            labelResult.Text = String.Format("{0} {1} selected the event {2}",
            firstname, lastname, selectedEvent);
        }
    }
}