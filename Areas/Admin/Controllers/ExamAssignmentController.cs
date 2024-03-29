using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DershaneOrnekSB.Data;
using DershaneOrnekSB.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace DershaneOrnekSB.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExamAssignmentController : Controller
    {
        private readonly DatabaseContext _context;

        public ExamAssignmentController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: ExamAssignment
        public async Task<IActionResult> Index()
        {
            var examAssignments = await _context.UserExamAssignments
                .Include(ea => ea.Exam)
                .Include(ea => ea.User)
                .ToListAsync();
            return View(examAssignments);
        }

        // GET: ExamAssignment/Create
        public IActionResult Create()
        {
            ViewBag.Exams = _context.Exams.ToList();
            ViewBag.Users = _context.Users.ToList();
            return View();
        }

        // POST: ExamAssignment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExamId, UserId, StartTime, EndTime")] UserExamAssignment examAssignment)
        {
            if (ModelState.IsValid)
            {
                // Yeni atamayı oluştur
                _context.Add(examAssignment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Atama oluşturma formunu tekrar göster
            ViewBag.Exams = _context.Exams.ToList();
            ViewBag.Users = _context.Users.ToList();
            return View(examAssignment);
        }
    }
}
