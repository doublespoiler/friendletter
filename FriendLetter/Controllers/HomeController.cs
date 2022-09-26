using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;


namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/hello")]
      public string Hello() { return "Hello friend!";}

      [Route("/goodbye")]
      public string Goodbye() {return "Goodbye friend.";}

      [Route("/")]
      public ActionResult Letter()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = "Lina";
        myLetterVariable.Sender = "Jasmine";
        return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form() { return View(); }

      [Route("/postcard")]
      public ActionResult PostCard(string recipient, string sender, string verb, string place1)
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.Recipient = recipient;
        myLetterVariable.Sender = sender;
        myLetterVariable.Verb = verb;
        myLetterVariable.Place1 = place1;
        return View(myLetterVariable);
      }
    }
}