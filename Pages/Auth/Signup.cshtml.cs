
using Microsoft.AspNetCore.Mvc.RazorPages;
using EventManagement.Models;
using Microsoft.AspNetCore.Mvc;
using EventManagement.Database.Connection;


namespace EventManagement.Pages.Auth;

public class SignModel : PageModel
{
    private readonly EventDbContext _context;
    public SignModel(EventDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public User UserDetails { get; set; } = new User();

    public string? Message;
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            Message = "Properly insert the correct Data.";
            return Page();
        }

        _context.Users.Add(UserDetails);
        _context.SaveChanges();
        return RedirectToPage("/Index");
    }
}