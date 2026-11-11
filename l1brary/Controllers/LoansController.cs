using l1brary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace l1brary.Controllers;

public class LoansController : Controller
{
    private readonly LoanRepository _loans;
    private readonly MemberRepository _members;
    private readonly BookRepository _books;

    public LoansController(LoanRepository loans, MemberRepository members, BookRepository books)
    {
        _loans = loans;
        _members = members;
        _books = books;
    }

    public async Task<IActionResult> Index()
    {
        var loans = await _loans.GetAllAsync();
        return View(loans);
    }
}
