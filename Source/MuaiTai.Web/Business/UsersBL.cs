using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MuaiTai.Web.BusinessObjects;
using MuaiTai.Web.Data;

namespace MuaiTai.Web.Business
{
  public static class UsersBL
  {
    static DAL _dal = new DAL(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
    public static void Register(User user)
    {
      string sql = "INSERT INTO [dbo].[Users]([UserName],[Password],[FirstName],[LastName],[PhoneNumber])" +
                   $@" VALUES('{user.UserName}','{user.Password}','{user.FirstName}','{user.LastName}','{user.PhoneNumber}')";
      var res = (int)_dal.Execute(sql);
      if (res != 1)
      {
        //error
      }
    }

    public static bool Login(string userName, string password)
    {
      string sql = $@"SELECT Count(*) FROM users WHERE userName='{userName}' AND password='{password}'";
      var res = (int)_dal.GetScalar(sql);
      return Convert.ToBoolean(res);
    }
  }
}