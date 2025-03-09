using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u23671922_INF272_Practical2.Models;

namespace u23671922_INF272_Practical2.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult People()
        {

            List<Person> persons = new List<Person>
            {
                new Person()
                {
                    Student_Number = "u23671922",
                    Name = "Tshami",
                    Surname = "Mongwe",
                    Email_Address = "u23671922@tuks.co.za",
                   myLink = "~/HTML/Person01.html"
                },
                new Person()
                {
                    Student_Number = "u24622915",
                    Name = "Natasha",
                    Surname = "Zulu",
                    Email_Address = "u24622915@tuks.co.za",
                   myLink = "~/HTML/Person02.html"
                },
                new Person()
                {
                    Student_Number = "u21671934",
                    Name = "Pride",
                    Surname = "Ndlovu",
                    Email_Address = "u21671934@tuks.co.za",
                   myLink = "~/HTML/Person03.html"
                },
                new Person()
                {
                    Student_Number = "u19687297",
                    Name = "Tshiamo",
                    Surname = "Mokwena",
                    Email_Address = "u19687297@tuks.co.za",
                   myLink = "~/HTML/Person04.html"
                },
                new Person()
                {
                    Student_Number = "u20651888",
                    Name = "Ayanda",
                    Surname = "Zikode",
                    Email_Address = "u20651888@tuks.co.za",
                   myLink = "~/HTML/Person05.html"
                },

            };


            return View(persons);
        }

    }

}