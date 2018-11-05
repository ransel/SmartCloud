using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartCloud.Model.Account;
using SmartCloud.Services.Interfaces;

namespace SmartCloud.Controllers
{
    public class UsersController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IMapperService _mapperService;
        private readonly ILoggingService _loggingService;

        public UsersController(IAccountService accountService, IMapperService mapperService, ILoggingService loggingService)
        {
            _accountService = accountService;
            _mapperService = mapperService;
            _loggingService = loggingService;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            _loggingService.LogInfo("Reading Users Get Method");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var users = await _accountService.GetAllUsers();
            var results = _mapperService.Map<List<Domain.Entities.User>, List<User>>(users);
            watch.Stop();
            _loggingService.LogInfo("Finished Reading Users Get Method", new Dictionary<string, string> { {"RetrieveUserDuration", watch.ElapsedMilliseconds.ToString()} });
            return View(results);
        }

//        // GET: Users/Details/5
//        public async Task<IActionResult> Details(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var user = await _context.User
//                .Include(u => u.UserType)
//                .FirstOrDefaultAsync(m => m.UserId == id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//
//            return View(user);
//        }
//
//        // GET: Users/Create
//        public IActionResult Create()
//        {
//            ViewData["UserTypeId"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId");
//            return View();
//        }
//
//        // POST: Users/Create
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Create([Bind("UserId,UserTypeId,LineOfBusinessId,EmployeeId,AuthorisedUser,FirstName,LastName,EmailAddress,MobileNumber,DeviceIdentifier,UserName,Password,UserConfig,CreateDate,CreateUser,LastModDate,LastModUser,LastModSystem")] User user)
//        {
//            if (ModelState.IsValid)
//            {
//                user.UserId = Guid.NewGuid();
//                _context.Add(user);
//                await _context.SaveChangesAsync();
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["UserTypeId"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeId);
//            return View(user);
//        }
//
//        // GET: Users/Edit/5
//        public async Task<IActionResult> Edit(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var user = await _context.User.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//            ViewData["UserTypeId"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeId);
//            return View(user);
//        }
//
//        // POST: Users/Edit/5
//        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> Edit(Guid id, [Bind("UserId,UserTypeId,LineOfBusinessId,EmployeeId,AuthorisedUser,FirstName,LastName,EmailAddress,MobileNumber,DeviceIdentifier,UserName,Password,UserConfig,CreateDate,CreateUser,LastModDate,LastModUser,LastModSystem")] User user)
//        {
//            if (id != user.UserId)
//            {
//                return NotFound();
//            }
//
//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    _context.Update(user);
//                    await _context.SaveChangesAsync();
//                }
//                catch (DbUpdateConcurrencyException)
//                {
//                    if (!UserExists(user.UserId))
//                    {
//                        return NotFound();
//                    }
//                    else
//                    {
//                        throw;
//                    }
//                }
//                return RedirectToAction(nameof(Index));
//            }
//            ViewData["UserTypeId"] = new SelectList(_context.UserType, "UserTypeId", "UserTypeId", user.UserTypeId);
//            return View(user);
//        }
//
//        // GET: Users/Delete/5
//        public async Task<IActionResult> Delete(Guid? id)
//        {
//            if (id == null)
//            {
//                return NotFound();
//            }
//
//            var user = await _context.User
//                .Include(u => u.UserType)
//                .FirstOrDefaultAsync(m => m.UserId == id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//
//            return View(user);
//        }
//
//        // POST: Users/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteConfirmed(Guid id)
//        {
//            var user = await _context.User.FindAsync(id);
//            _context.User.Remove(user);
//            await _context.SaveChangesAsync();
//            return RedirectToAction(nameof(Index));
//        }
//
//        private bool UserExists(Guid id)
//        {
//            return _context.User.Any(e => e.UserId == id);
//        }
    }
}
