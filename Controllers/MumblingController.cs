
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExplosiveApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class MumblingController : ControllerBase
  {
    [HttpGet]
    public ActionResult Mumbling(string s)
    {
      string myString = "";
      int myIndex = 0;

      foreach (char i in s)
      {
        if (myIndex != 0)
        {
          myString += '-';
        }
        myString += s[myIndex].ToString().ToUpper();
        for (int j = 0; j < myIndex; j++)
        {
          myString += s[myIndex].ToString().ToLower();
        }
        myIndex++;
      }

      // return Ok(new { returnString });
      return Ok(new { Mumbling = myString });
    }
  }

}