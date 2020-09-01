using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MuaiTai.Web.BusinessObjects;
using MuaiTai.Web.Data;

namespace MuaiTai.Web.Business
{
  public static class FightersBL
  {
    static DAL _dal = new DAL(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);

    public static List<Fighter> GetFighters()
    {
      return new List<Fighter>();
    }
    public static List<Coach> GetCoaches()
    {
      return new List<Coach>();
    }
    public static List<ClubGuest> GetClubGuests()
    {
      return new List<ClubGuest>();
    }
  }
}