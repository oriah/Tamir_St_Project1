using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MuaiTai.Web.BusinessObjects
{
  public class Profession
  {
    public int ProfessionId { get; set; }
    public string Name { get; set; }

    public Profession()
    {

    }

    public Profession(int professionId, string name)
    {
      ProfessionId = professionId;
      Name = name;
    }
  }
}