using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NOSsmsProject
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int userVal = int.Parse(Textbox2.Text);
            NOS_SMSReference1.SMSPROWSSoapClient newList = new NOS_SMSReference1.SMSPROWSSoapClient();
            newList.CreateList("totallink1", "totallink20", "KcjMs", Textbox1.Text, true, out userVal);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}