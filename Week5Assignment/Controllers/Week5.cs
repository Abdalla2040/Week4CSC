using Microsoft.AspNetCore.Mvc;

namespace Week5Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Week5 : ControllerBase
    {
        

        [HttpPost(Name = "Week5IndividualAssignment")]
        public ActionResult<List<People>> LogObject([FromBody] List<People> input)
        {

            input.ForEach(x => Console.WriteLine(
                                       "ID: " + x.Id + "\n" + 
                                       "First Name: " + x.Fname + "\n" + 
                                       "Last Name: " + x.Lname + "\n" + 
                                       "Date of Birth: " + x.DOB + "\n"
                                       ));
            return input;
        }
    }
}