using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;

namespace MeetingApp.Controllers
{
      public class HomeController:Controller
      {
             public IActionResult Index()
             {
                int saat=DateTime.Now.Hour;
        
                 ViewBag.selamla=saat >18 ? "İyi Akşamlar":"İyi Günler";
                 int UserCount=Repository.Users.Where(info=>info.WillAttend==true).Count();
                 //ViewBag.Username="Emre";


                 //ViewData["Username"]="Emre";
                // ViewData["selamla"]=saat >18 ? "İyi Akşamlar":"İyi Günler";


                var Meetinginfo =new Meetinginfo()
                {
                    Id=1,
                    Location="Abc Kongre Merkezi,İstanbul",
                    Date= new DateTime(2024,01,20,20,0,0),
                    NumberOfPeople=UserCount

                };


                 return View(Meetinginfo);



             }
      
      }














}