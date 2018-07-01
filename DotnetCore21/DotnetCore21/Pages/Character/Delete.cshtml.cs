using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DotnetCore21.Models;
using DotnetCore21.Models.Character;

namespace DotnetCore21.Pages.Character
{
    public class DeleteModel : PageModel
    {
        private readonly DotnetCore21.Models.MainContext _context;

        public DeleteModel(DotnetCore21.Models.MainContext context)
        {
            _context = context;
        }

        [BindProperty]
        public A_Character CharacterBase { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterBase = await _context.Characters.FirstOrDefaultAsync(m => m.Id == id);

            if (CharacterBase == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CharacterBase = await _context.Characters.FindAsync(id);

            if (CharacterBase != null)
            {
                _context.Characters.Remove(CharacterBase);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
