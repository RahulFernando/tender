using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ceb_tender_app.Controllers
{
    public class RoleController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();


            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        // create new role
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole identityRole)
        {
            await _roleManager.CreateAsync(identityRole);
            return RedirectToAction("Index");
        }
    }
}