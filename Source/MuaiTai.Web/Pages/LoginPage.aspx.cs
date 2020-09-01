using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MuaiTai.Web.Business;

namespace MuaiTai.Web.Pages
{
  public partial class LoginPage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btn_Click(object sender, EventArgs e)
    {
      bool isOK = UsersBL.Login(tbxUserName.Text, tbxPassword.Text);
      if (!isOK)
      {
        this.lblStatus.Text = "Wrong username and/or password !!";
        this.lblStatus.Visible = true;
      }
    }
  }
}