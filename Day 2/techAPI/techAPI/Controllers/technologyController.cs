using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace techAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class technologyController : ControllerBase
    {

        #region Data Store
        //DataSource
        private static List<string> techList = new List<string>()
        {
            "ASP.net MVC","SQL Server","Sharepoint","WEBAPI","Angular","React","Azure"
        };
        #endregion

        #region Get methods
        //get all the technologies
        [HttpGet]
        [Route("list")]
        public IActionResult GetTechlist()
        {
            return Ok(techList);
        }

        //get technology by index
        [HttpGet]
        [Route("list/{idx}")]
        public IActionResult GetTechnologyByPosition(int idx)
        {
            if (idx < techList.Count)
            {
                return Ok(techList[idx]);
            }
            else
            {
                return NotFound("Sorry please enter position less than " + techList.Count);
            }
        }
        //get total count
        [HttpGet]
        [Route("total")]
        public IActionResult GetTotalTechnolgy()
        {
            return Ok(techList.Count);
        }

        [HttpGet]
        [Route("sort")]
        public IActionResult Sorttechnology()
        {
            var sortedList = from t in techList
                             orderby t
                             select t;
            return Ok(sortedList);
        }

        [HttpGet]
        [Route("list/search/{namelike}")]
        public IActionResult GetTechnologyByName(string namelike)
        {
            var tech = from t in techList
                       where t.StartsWith(namelike)
                       select t;
            return Ok(tech);
        }
        #endregion

        #region Add new Technology

        [HttpPost]
        [Route("list/add/{newtechname}")]
        public IActionResult AddNewTechnolgy(string newtechname)
        {
            if (newtechname.Length < 3)
            {
                return Ok("Please provide a valid technology name");
            }
            techList.Add(newtechname);
            return Created("", "Technology Added Successfully");
        }
        #endregion

        #region Delete Technology

        [HttpDelete]
        [Route("list/delete/{position}")]
        public IActionResult DeleteTechnology(int position)
        {
            if (techList.Count > position)
            {
                techList.RemoveAt(position);
                return Accepted("Technolgy removed from the stack");
            }
            else
            {
                return NotFound("Technology not found in the list");
            }
        }
        #endregion

        #region Edit Technology

        [HttpPut]
        [Route("list/edit/{position}/{newname}")]
        public IActionResult EditTechName(int position, string newname)
        {

            techList[position] = newname;
            return Accepted("Change Successful");

        }


        #endregion


    }
}

















