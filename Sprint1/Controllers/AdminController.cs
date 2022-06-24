using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Sprint1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sprint1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        DbConnect con;
        DAL dl;
        public AdminController(DbConnect con)
        {
            this.con = con;
            dl = new DAL(con);
        }
        // GET: api/<AdminController>
        [EnableCors]
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            List<Movie> ls = con.Movies.ToList();
            return ls;
        }

        // GET api/<AdminController>/5

        [HttpGet("{id}")]

        public Movie Get(int id)
        {
            Movie obj = con.Movies.Find(id);
            return obj;
        }

           // POST api/< AdminController >
    
            [HttpPost]
        public void post([FromBody] string value)
            {

            }

            //PUT api/< AdminController >/ 5
           [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
            {
            }

           // DELETE api/< AdminController >/ 5
           [HttpDelete("{id}")]
        public void Delete(int id)
            {
            }
        }
    }

