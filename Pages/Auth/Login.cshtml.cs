using EventManagement.Database.Connection;
using EventManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventManagement.Pages.Auth;

public class LoginModel : PageModel
{
    private readonly EventDbContext _context;
    public LoginModel(EventDbContext context) => _context = context;



    [BindProperty]
    public string InputEmail { get; set; } = string.Empty;

    [BindProperty]
    public string InputPassword { get; set; } = string.Empty;

    [BindProperty]
    public string ConfirmInputPassword { get; set; } = string.Empty;

    public string Message = string.Empty;


    public void OnGet() { }
    
    public IActionResult OnPost()
    {

        if (!ConfirmInputPassword.Equals(InputPassword))
        {
            Message = "Please have same password i both fields";
            return Page();
        }

        var users = _context.Users.FirstOrDefault(user => user.Email == InputEmail && user.Password == InputPassword);

        if (users == null)
        {
            Message = "There is no such user account.";
            return Page();
        }

           HttpContext.Session.SetString("UserId", users.UserId.ToString());
        HttpContext.Session.SetString("UserName", users.Name);
            HttpContext.Session.SetString("UserRole", users.Role.ToString());

        if (users.Role == Role.Admin)
        {
            return RedirectToPage("/Index");
        }
        else
        {
            return RedirectToPage("/Index");
        }

     }
}
