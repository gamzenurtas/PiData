using E_Ticaret_BLL.Models;
using E_Ticaret_WEBUI.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Ticaret_WEBUI.Controllers
{
    public class AccountController : Controller
    {
        E_Ticaret_DAL.Context.DataContext db = new E_Ticaret_DAL.Context.DataContext();

        private UserManager<ApplicationUser> userManager;
        private RoleManager<ApplicationRole> roleManager;


        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new DataContext());
            userManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<ApplicationRole>(new DataContext());
            roleManager = new RoleManager<ApplicationRole>(roleStore);
        }


        [Authorize]
        public ActionResult Index()
        {
            

            return View();
        }

        [Authorize]
        public ActionResult Details(int id)
        {
          
            return View();
        }
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt işlemleri
                var user = new ApplicationUser();
                user.Name = model.Name;
                user.Surname = model.Surname;
                user.Email = model.Email;
                user.UserName = model.Username;

                var result = userManager.Create(user, model.Password);

                if (result.Succeeded)
                {
                    //Kullanıcı oluştu ve kullanıcıya bir rol atayabiliriz.
                    if (roleManager.RoleExists("user"))
                    {
                        userManager.AddToRole(user.Id, "user");                        
                    }
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError", "Kullanıcı oluşturma hatası");
                }
            }
            return View(model);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //Login işlemleri
                var user = userManager.Find(model.Username, model.Password);

                if(user != null)
                {
                    //varolan kullanıcıyı sisteme dahil et.
                    //ApplicationCookie oluşturup sisteme bırak.

                    var authManager = HttpContext.GetOwinContext().Authentication;
                    var identityClaims = userManager.CreateIdentity(user, "ApplicationCookie");
                    var authProperties = new AuthenticationProperties();
                    authProperties.IsPersistent = model.RememberMe;
                    authManager.SignIn(authProperties, identityClaims);

                    if (!String.IsNullOrEmpty(ReturnUrl))
                    {
                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                else
                {
                    ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok.");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            var authManager = HttpContext.GetOwinContext().Authentication;
            authManager.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}