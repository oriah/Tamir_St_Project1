using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaiTai.Web.BusinessObjects
{
  public class Coach : FighterBase
  {
    public Coach()
    {

    }

    protected Coach(int coachId, string firstName, string lastName, int fightLevel, int professionId) :
      base(coachId, firstName, lastName, fightLevel, professionId)
    {

    }
  }
}