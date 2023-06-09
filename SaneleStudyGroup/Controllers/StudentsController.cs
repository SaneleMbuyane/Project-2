using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SaneleStudyGroup.Controllers
{
    public class StudentsController : Controller
    {
        
        public ActionResult Home()
        {
            List<Students> students = new List<Students>();

            students.Add(new Students { StudentNumber = 22614835, Name= "Sanele", Surname= "Mbuyane", EmailAddress="u22614835@tuks.co.za", myLink= "~/HTML/Sanele.html",DeleteBuddy="Delete" });
            students.Add(new Students { StudentNumber = 21616672, Name = "Thabo", Surname = "Bosvark", EmailAddress = "u23591570@tuks.co.za", myLink = "~/HTML/Thabo.html" ,DeleteBuddy= "Delete" });
            students.Add(new Students { StudentNumber = 22526884, Name = "Asanda", Surname = "Mazibuko", EmailAddress = "u22610635@tuks.co.za", myLink = "~/HTML/Asanda.html" ,DeleteBuddy= "Delete" });
            students.Add(new Students { StudentNumber = 23756973, Name = "Anouk", Surname = "Du Plooy", EmailAddress = "u21652296@tuks.co.za", myLink = "~/HTML/Anouk.html",DeleteBuddy= "Delete" });
            students.Add(new Students { StudentNumber = 22435617, Name = "Noah", Surname = "Maile", EmailAddress = "u21477729@tuks.co.za", myLink = "~/HTML/Noah.html",DeleteBuddy= "Delete" });
            
    
            return View(students);
        }
        


    }
}