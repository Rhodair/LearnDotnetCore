using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DotnetCore21.Models;
using DotnetCore21.Models.Character;

namespace DotnetCore21.Pages.Character
{
    public class CreateModel : PageModel
    {
        private readonly DotnetCore21.Models.MainContext _context;

        public CreateModel(DotnetCore21.Models.MainContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public A_Character CharacterBase { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Characters.Add(CharacterBase);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}