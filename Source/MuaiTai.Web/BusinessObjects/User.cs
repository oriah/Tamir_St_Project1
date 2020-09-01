using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaiTai.Web.BusinessObjects
{
  public class User    //viewer
  {
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public User()
    {

    }

    public User(string userName, string password, string firstName, string lastName, string phoneNumber)
    {
      UserName = userName;
      Password = password;
      FirstName = firstName;
      LastName = lastName;
      PhoneNumber = phoneNumber;
    }
  }
}