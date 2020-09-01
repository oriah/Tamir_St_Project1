using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MuaiTai.Web.Business;
using MuaiTai.Web.BusinessObjects;

namespace MuaiTai.Web.Pages
{
  public partial class RegisterPage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btn_Click(object sender, EventArgs e)
    {
      User user = new User(tbxUserName.Text, tbxPassword.Text, tbxFirstName.Text, tbxLastName.Text, tbxPhoneNumber.Text);
      UsersBL.Register(user);
    }
  }
}