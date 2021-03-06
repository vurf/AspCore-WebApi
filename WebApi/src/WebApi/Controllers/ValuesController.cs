﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        static List<ScoreEntity> scores;
        public List<ScoreEntity> Scores {
            get {
                return scores ?? (scores = new List<ScoreEntity>());
            }
        }



        // GET: api/values
        [HttpGet]
        public IEnumerable<ScoreEntity> Get()
        {
            return Scores;
            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ScoreEntity Get(int id)
        {
            return Scores[id];
        }

        // POST api/values
        [HttpPost]
        public HttpStatusCodeResult Post([FromBody]ScoreEntity value)
        {
            Scores.Add(value);
            return new HttpStatusCodeResult(200);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Scores.RemoveAt(id);
        }
    }
}
