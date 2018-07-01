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
    public class DetailsModel : PageModel
    {
        private readonly DotnetCore21.Models.MainContext _context;

        public DetailsModel(DotnetCore21.Models.MainContext context)
        {
            _context = context;
        }

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
    }
}
