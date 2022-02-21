using Microsoft.AspNetCore.Mvc;
using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            IList<AccountModel> acc = new List<AccountModel>();
            acc.Add(new AccountModel() { AccountId = 1234, AccountName = "Thoushif", AccountAddress = "Tvr" });
            acc.Add(new AccountModel() { AccountId = 4567, AccountName = "Mohamed", AccountAddress = "Karur" });
            acc.Add(new AccountModel() { AccountId = 7894, AccountName = "Mohamed", AccountAddress = "Nag" });

            ViewData["acc"] = acc;

            ViewBag.TotalAccounts = acc.Count();
            ViewBag.BranchName = "IOB";

            return View();
        }
    }
}
