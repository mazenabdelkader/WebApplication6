using Data_Acess_Layer.data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Presentation_Layer.Models.ViewModels.ForgetPasswordViewModel;
using Presentation_Layer.Models.ViewModels.Login_view_Model;
using Presentation_Layer.Models.ViewModels.RegisterViewModel;
using Presentation_Layer.Models.ViewModels.ResetPasswordViewModel;
using WebApplication6.Controllers;

namespace Presentation_Layer.Controllers
{
//    public class AccountCountroller(UserManager<AppDBContext> _userManager, SignInManager<AppDBContext> _signInManager) : Controller    
//    {
//        #region Register
//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public IActionResult Register(RegisterViewModel ViewModel)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(ViewModel);
//            }

//            var User = new AppDBContext()
//            {
//                FirstName = ViewModel.FirstName,
//                LastName = ViewModel.LastName,
//                Email = ViewModel.Email,
//                UserName = ViewModel.UserName
//            };

//            var Result = _userManager.CreateAsync(User, ViewModel.Password).Result;
//            if (Result.Succeeded)
//            {
//                return RedirectToAction("Login");
//            }
//            else
//            {
//                foreach (var error in Result.Errors)
//                {
//                    ModelState.AddModelError(string.Empty, error.Description);

//                }
//                return View(ViewModel);
//            }
//        }
//        #endregion

//        #region Login
//        [HttpGet]
//        public IActionResult Login()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Login(LoginViewModel ViewModel)
//        {
//            if (!ModelState.IsValid)
//            {
//                return View(ViewModel);
//            }
//            var User = _userManager.FindByEmailAsync(ViewModel.Email).Result;
//            if (User is not null)
//            {
//                bool flag = _userManager.CheckPasswordAsync(User, ViewModel.Password).Result;
//                if (flag)
//                {
//                    var Result = _signInManager.PasswordSignInAsync(User, ViewModel.Password, ViewModel.RememberMe, false).Result;
//                    if (Result.IsNotAllowed)
//                    {
//                        ModelState.AddModelError(string.Empty, "Your Account Is Not Allowed");
//                    }

//                    if (Result.IsLockedOut)
//                    {
//                        ModelState.AddModelError(string.Empty, "Your Account Is Locked");
//                    }
//                    if (Result.Succeeded)
//                    {
//                        return RedirectToAction(nameof(HomeController.Index), "Home");
//                    }
//                }
//            }
//            else
//            {
//                ModelState.AddModelError(string.Empty, "Invalid Login");

//            }
//            return View(ViewModel);
//        }
//        #endregion

//        #region SignOut
//        [HttpGet]
//        public IActionResult SignOut()
//        {
//            _signInManager.SignOutAsync().GetAwaiter().GetResult();
//            return RedirectToAction(nameof(Login));
//        }

//        #endregion

//        #region ForgetPassword

//        [HttpGet]
//        public IActionResult ForgetPassword()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult SendResetPasswordLink(ForgertPassword viewModel)

//        {
//            if (ModelState.IsValid)
//            {
//                var user = _userManager.FindByEmailAsync(viewModel.Email).Result;
//                if (user is not null)
//                {
//                    var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;

//                    var resetPasswordLink = Url.Action(
//                        "ResetPassword",
//                        "Account",
//                        new { email = viewModel.Email, token = token },
//                        protocol: Request.Scheme);

//                    var email = new Email()
//                    {
//                        To = viewModel.Email,
//                        Subject = "Reset Password",
//                        Body = $"Please reset your password by clicking <a href='{resetPasswordLink}'>here</a>"
//                    };

//                    EmailSettings.SendEmail(email);
//                    return RedirectToAction(nameof(CheckYourInbox));
//                }
//            }

//            ModelState.AddModelError(string.Empty, "Invalid Operation");
//            return View(nameof(ForgetPassword), viewModel);
//        }
//        #endregion

//        #region CheckYourInbox
//        [HttpGet]
//        public IActionResult CheckYourInbox()
//        {
//            return View();
//        }
//        #endregion

//        [HttpGet]
//        public IActionResult ResetPassword(string email, string Token)
//        {
//            TempData["email"] = email;
//            TempData["Token"] = Token;

//            return View();
//        }


//        [HttpPost]
//        public IActionResult ResetPassword(ResetPassword viewModel)
//        {

//            if (!ModelState.IsValid) return View(viewModel);

//            string email = TempData["email"] as string ?? string.Empty;
//            string Token = TempData["Token"] as string ?? string.Empty;
//            var User = _userManager.FindByEmailAsync(email).Result;
//            if (User is not null)
//            {
//                var Result = _userManager.ResetPasswordAsync(User, Token, viewModel.Password).Result;
//                if (Result.Succeeded)
//                {
//                    return RedirectToAction(nameof(Login));
//                }

//                else
//                {
//                    foreach (var error in Result.Errors)
//                    {
//                        ModelState.AddModelError(string.Empty, error.Description);
//                    }
//                }

//            }
//            return View(nameof(ResetPassword), viewModel);

//        }
    

//}
}
