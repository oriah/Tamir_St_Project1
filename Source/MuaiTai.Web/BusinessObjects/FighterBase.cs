using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaiTai.Web.BusinessObjects
{
  public abstract class FighterBase
  {
    public int CoachId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int FightLevel { get; set; }    //1-5
    public int ProfessionId { get; set; }

    protected FighterBase()
    {

    }

    protected FighterBase(int coachId, string firstName, string lastName, int fightLevel, int professionId)
    {
      CoachId = coachId;
      FirstName = firstName;
      LastName = lastName;
      FightLevel = fightLevel;
      ProfessionId = professionId;
    }

  }
}