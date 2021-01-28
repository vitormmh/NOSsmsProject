using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NOSsmsProject
{
    public partial class _Default : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NOS_SMSReference1.SMSPROWSSoapClient sms = new NOS_SMSReference1.SMSPROWSSoapClient();
            sms.SendSMS("totallink1", "totallink20", "KcjMs", nrtelemovel.Text, floatingTextarea.Text);
        }
       
        protected void Button6_Click(object sender, EventArgs e)
        {
            int userVal = Convert.ToInt32(Textbox2.Text);
            NOS_SMSReference1.SMSPROWSSoapClient newList = new NOS_SMSReference1.SMSPROWSSoapClient();
            newList.CreateList("totallink1", "totallink20", "KcjMs", Textbox1.Text, true, out userVal);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //DateTime data = Convert.ToDateTime(Textbox3.Text);
            //NOS_SMSReference1.SMSPROWSSoapClient ListarListas = new NOS_SMSReference1.SMSPROWSSoapClient();
            //NOS_SMSReference1.List_Record lr = new NOS_SMSReference1.List_Record();
            //lr.Active = true;
            //lr.Count = 4;
            //lr.Name = "";
            //lr.Username = "totallink20";

            //  List <NOS_SMSReference1.List_Record> li = new List<NOS_SMSReference1.List_Record>();
            //li.Add(lr);
   
            
            //ListarListas.GetLists("", "", "", data, out teste.ToString);
        }

      

        //protected void Button5_Click(object sender, EventArgs e)
        //{
        //    NOS_SMSReference1.SMSPROWSSoapClient addmemb = new NOS_SMSReference1.SMSPROWSSoapClient();
        //    var mem = new NOS_SMSReference1.Members();
        //    mem.Parameters = new NOS_SMSReference1.Parameter() {
        //        Key = "928063189", Value=""
             
        //    };
        //    List<NOS_SMSReference1.Members> membro = new List<NOS_SMSReference1.Members>();
        //    membro.Add(mem);
        //    addmemb.AddMembers("totallink1", "totallink20", "KCT", 2222, membro.ToArray(),out );
        //}
    }
}