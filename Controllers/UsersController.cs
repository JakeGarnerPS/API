using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using webapi.Models;

namespace webapi.Controllers
{
    
    public class UsersController : ApiController
    {
        private User[] users = new User[]
        {
            new User {Id = 1, Name = "Yeeeet Magee", Email = "email1@mail.com", Phone = "01101111101", Role =1},
            new User {Id = 2, Name = "mr bob", Email = "email2@mail.com", Phone = "022222201", Role =1},
            new User {Id = 3, Name = "Poopy Whoop", Email = "email3@mail.com", Phone = "01101333333", Role =1},
            new User {Id = 4, Name = "Loopy loo", Email = "email4@mail.com", Phone = "0110144444", Role =2},
            new User {Id = 5, Name = "Ice Cold 3000", Email = "email5@mail.com", Phone = "05555555", Role =3}
        };

        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}
