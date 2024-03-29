using DershaneOrnekSB.Data;
using DershaneOrnekSB.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DershaneOrnekSB.Controllers // YourProjectName, projenizin adıyla değiştirilmelidir.
{
    [Area("Admin"), Authorize(Roles = "Admin")]
    public class ExamController : Controller
    {
        private readonly DatabaseContext _context;

        public ExamController(DatabaseContext context)
        {
            _context = context;
        }


        // GET: Exam
        public async Task<IActionResult> Index()
        {
            var exams = await _context.Exams.Include(e => e.Category).ToListAsync();
            return View(exams);
        }


        // GET: Exam/Create
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        // POST: Exam/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,StartTime,EndTime,CategoryId")] Exam exam)
        {

            var category = await _context.Categories.FindAsync(exam.CategoryId);
            if (category == null)
            {
                ModelState.AddModelError(string.Empty, "Geçersiz kategori seçimi.");
                ViewBag.Categories = _context.Categories.ToList();
                return View(exam);
            }

            exam.Category = category;

            _context.Add(exam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));



        }





        // GET: Exam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams.FindAsync(id);
            if (exam == null)
            {
                return NotFound();
            }
            ViewBag.Categories = _context.Categories.ToList();
            return View(exam);
        }

        // POST: Exam/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,StartTime,EndTime,CategoryId")] Exam exam)
        {
            if (id != exam.Id)
            {
                return NotFound();
            }


            var category = await _context.Categories.FindAsync(exam.CategoryId);
            if (category == null)
            {
                ModelState.AddModelError(string.Empty, "Geçersiz kategori seçimi.");
                ViewBag.Categories = _context.Categories.ToList();
                return View(exam);
            }

            exam.Category = category;

            _context.Update(exam);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));


        }



        // GET: Exam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exam = await _context.Exams
                .Include(e => e.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exam == null)
            {
                return NotFound();
            }

            return View(exam);
        }

        // POST: Exam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exam = await _context.Exams.FindAsync(id);
            _context.Exams.Remove(exam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddQuestions(int id, List<Question> questions)
        {
            var exam = _context.Exams
                .Include(e => e.Questions)
                .FirstOrDefault(e => e.Id == id);

            if (exam == null)
            {
                return NotFound();
            }

            foreach (var question in questions)
            {
                // Soruyu sınavla ilişkilendir
                exam.Questions.Add(question);
            }

            _context.SaveChanges(); // Değişiklikleri veritabanına kaydet

            return RedirectToAction(nameof(Index)); // veya başka bir sayfaya yönlendirme yapılabilir
        }

    }
}