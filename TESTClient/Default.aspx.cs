using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TESTClient.ServiceReference1;

namespace TESTClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserClient userClient = new UserClient();
            string result = userClient.ShowName(this.TextBox1.Text);
            TextBox2.Text = result;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference2.TESTWebService1SoapClient ws = new ServiceReference2.TESTWebService1SoapClient();
            string result = ws.HelloWorld(this.TextBox3.Text);
            TextBox4.Text = result;
        }
    }
}