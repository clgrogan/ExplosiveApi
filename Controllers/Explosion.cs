
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExplosiveApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ExplosionController : ControllerBase
  {
    [HttpGet]
    public ActionResult Explosion(string s)
    {
      string returnString = "";
      for (int i = 0; i < s.Length; i++)
      {
        int numVal = Int32.Parse(char.ToString(s[i]));
        for (int j = 0; j < numVal; j++)
        {
          if (numVal != 0)
          {
            returnString += s[i];
          }
        }
      }
      return Ok(new { Explosion = returnString });
    }
  }
}