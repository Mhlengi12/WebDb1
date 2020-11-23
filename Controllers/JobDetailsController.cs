﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDb1.Data;
using WebDb1.Models;

namespace WebDb1.Controllers
{
    public class JobDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JobDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: JobDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobDetails.ToListAsync());
        }

        // GET: JobDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDetails = await _context.JobDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobDetails == null)
            {
                return NotFound();
            }

            return View(jobDetails);
        }

        // GET: JobDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Employeenumber,Payment,History,JobLevel,JobRole,JobSatisfaction,OverTime,AccessLevel")] JobDetails jobDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobDetails);
        }

        // GET: JobDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDetails = await _context.JobDetails.FindAsync(id);
            if (jobDetails == null)
            {
                return NotFound();
            }
            return View(jobDetails);
        }

        // POST: JobDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Employeenumber,Payment,History,JobLevel,JobRole,JobSatisfaction,OverTime,AccessLevel")] JobDetails jobDetails)
        {
            if (id != jobDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobDetailsExists(jobDetails.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(jobDetails);
        }

        // GET: JobDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobDetails = await _context.JobDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobDetails == null)
            {
                return NotFound();
            }

            return View(jobDetails);
        }

        // POST: JobDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobDetails = await _context.JobDetails.FindAsync(id);
            _context.JobDetails.Remove(jobDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobDetailsExists(int id)
        {
            return _context.JobDetails.Any(e => e.Id == id);
        }
    }
}
