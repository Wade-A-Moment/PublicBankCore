using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankCore.Interfaces;
using BankCore.Models;
using Microsoft.AspNetCore.Identity;

namespace BankCore.Controllers
{
    public class HomeController : Controller
    {

        // private readonly UserManager<ApplicationUser> _userManager;
        // private readonly SignInManager<ApplicationUser> _signInManager;
        // private readonly IBankRepository _bankRepository;
        // 
        // public HomeController(
        //     UserManager<ApplicationUser> userManager,
        //     SignInManager<ApplicationUser> signInManager,
        //     IBankRepository bankRepository
        //     )
        // {
        //     _userManager = userManager;
        //     _signInManager = signInManager;
        //     _bankRepository = bankRepository;
        // }

        public IActionResult Index()
        {
            // if (_signInManager.IsSignedIn(User))
            // {
            //     ViewBag.UserName = _userManager.GetUserName(User);
            //     return View(_bankRepository.ListAccountsByUserId(_userManager.GetUserId(User)));
            // }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Application Requirements:";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Wade Kelley";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
