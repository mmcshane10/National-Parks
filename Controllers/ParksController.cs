using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NationalParks.Models;

namespace NationalParks.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    public class ParksController : ControllerBase
    {
        private NationalParksContext _db;

        public ParksController(NationalParksContext db)
        {
            _db = db;
        }

        // GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get(string name, string states, string description)
        {
            var query = _db.Parks.AsQueryable();

            if (name != null)
            {
                query = query.Where(entry => entry.Name.Contains(name));
            }

            if (states != null)
            {
                query = query.Where(entry => entry.States.Contains(states));
            }

            if (description != null)
            {
                query = query.Where(entry => entry.Description.Contains(description));
            }

            return query.ToList();
        }

        // GET api/parks/5
        [HttpGet("{id}")]
        public ActionResult<Park> Get(int id)
        {
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
        }

        // RANDOM api/parks/random
        [HttpGet("random")]
        public ActionResult<Park> Random(int random)
        {
            Random rnd = new Random();
            int length = _db.Parks.ToList().Count + 1;
            random = rnd.Next(1, length);
            return _db.Parks.FirstOrDefault(entry => entry.ParkId == random);
        }

        // POST api/parks
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }

        // PUT api/parks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/parks/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
    }
}