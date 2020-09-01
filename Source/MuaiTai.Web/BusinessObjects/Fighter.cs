using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaiTai.Web.BusinessObjects
{
  public class Fighter : FighterBase
  {
    public Fighter()
    {

    }

    protected Fighter(int coachId, string firstName, string lastName, int fightLevel, int professionId) :
      base(coachId, firstName, lastName, fightLevel, professionId)
    {

    }
  }
}