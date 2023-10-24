using System;
using System.Web.UI;
using WCFServiceHost1;

namespace WebForm
{
    public partial class Clientes : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void novoCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Home/Create");
        }
    }
}
