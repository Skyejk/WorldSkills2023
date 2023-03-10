using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Entities;

namespace WebApi.Controllers
{
    public class HumenController : ApiController
    {
        private BaseEntities db = new BaseEntities();

        // GET: api/Humen
        public IQueryable<Human> GetHuman()
        {
            return db.Human;
        }

        // GET: api/Humen/5
        [ResponseType(typeof(Human))]
        public IHttpActionResult GetHuman(int id)
        {
            Human human = db.Human.Find(id);
            if (human == null)
            {
                return NotFound();
            }

            return Ok(human);
        }

        // PUT: api/Humen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHuman(int id, Human human)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != human.ID)
            {
                return BadRequest();
            }

            db.Entry(human).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HumanExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Humen
        [ResponseType(typeof(Human))]
        public IHttpActionResult PostHuman(Human human)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Human.Add(human);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = human.ID }, human);
        }

        // DELETE: api/Humen/5
        [ResponseType(typeof(Human))]
        public IHttpActionResult DeleteHuman(int id)
        {
            Human human = db.Human.Find(id);
            if (human == null)
            {
                return NotFound();
            }

            db.Human.Remove(human);
            db.SaveChanges();

            return Ok(human);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HumanExists(int id)
        {
            return db.Human.Count(e => e.ID == id) > 0;
        }
    }
}