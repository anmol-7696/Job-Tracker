using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobTracker.Api.Data;
using JobTracker.Api.Models;

namespace JobTracker.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobApplicationsController : ControllerBase
    {
        private readonly JobTrackerContext _context;

        public JobApplicationsController(JobTrackerContext context)
        {
            _context = context;
        }

        // GET: api/jobapplications
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobApplication>>> GetAll()
        {
            return await _context.JobApplications
                .OrderByDescending(j => j.DateApplied)
                .ToListAsync();
        }

        // GET: api/jobapplications/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JobApplication>> GetById(int id)
        {
            var job = await _context.JobApplications.FindAsync(id);

            if (job == null)
                return NotFound();

            return job;
        }

        // POST: api/jobapplications
        [HttpPost]
        public async Task<ActionResult<JobApplication>> Create(JobApplication job)
        {
            _context.JobApplications.Add(job);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = job.Id }, job);
        }

        // PUT: api/jobapplications/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, JobApplication job)
        {
            if (id != job.Id)
                return BadRequest();

            _context.Entry(job).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.JobApplications.Any(j => j.Id == id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // DELETE: api/jobapplications/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var job = await _context.JobApplications.FindAsync(id);

            if (job == null)
                return NotFound();

            _context.JobApplications.Remove(job);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}