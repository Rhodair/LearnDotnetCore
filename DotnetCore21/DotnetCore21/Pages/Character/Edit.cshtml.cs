using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DotnetCore21.Models;
using DotnetCore21.Models.Character;

namespace DotnetCore21.Pages.Character
{
    public class EditModel : PageModel
    {
        private readonly DotnetCore21.Models.MainContext _context;

        public EditModel(DotnetCore21.Models.MainContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CharacterBase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterBaseExists(CharacterBase.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CharacterBaseExists(int id)
        {
            return _context.Characters.Any(e => e.Id == id);
        }
    }
}
