﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlightsDatabase.Models;

namespace FlightsDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanesController : ControllerBase
    {
        private readonly FlightsContext _context;

        public PlanesController(FlightsContext context)
        {
            _context = context;
        }

        // GET: api/Planes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plane>>> GetPlanes()
        {
            return await _context.Planes.ToListAsync();
        }

        // GET: api/Planes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Plane>> GetPlane(int id)
        {
            var plane = await _context.Planes.FindAsync(id);

            if (plane == null)
            {
                return NotFound();
            }

            return plane;
        }

        // PUT: api/Planes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlane(int id, Plane plane)
        {
            if (id != plane.Id)
            {
                return BadRequest();
            }

            _context.Entry(plane).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlaneExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Planes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Plane>> PostPlane(Plane plane)
        {
            _context.Planes.Add(plane);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPlane", new { id = plane.Id }, plane);
        }

        // DELETE: api/Planes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Plane>> DeletePlane(int id)
        {
            var plane = await _context.Planes.FindAsync(id);
            if (plane == null)
            {
                return NotFound();
            }

            _context.Planes.Remove(plane);
            await _context.SaveChangesAsync();

            return plane;
        }

        private bool PlaneExists(int id)
        {
            return _context.Planes.Any(e => e.Id == id);
        }
    }
}
