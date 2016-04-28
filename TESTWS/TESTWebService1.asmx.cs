using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TESTWS
{
    /// <summary>
    /// Summary description for TESTWebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class TESTWebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string s)
        {
            return "调用ASMX处理后的文本为："+s;
        }
    }
}
