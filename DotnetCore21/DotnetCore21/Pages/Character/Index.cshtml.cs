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
    public class IndexModel : PageModel
    {
        private readonly DotnetCore21.Models.MainContext _context;

        public IndexModel(DotnetCore21.Models.MainContext context)
        {
            _context = context;
        }

        public IList<A_Character> CharacterBase { get;set; }

        public async Task OnGetAsync()
        {
            CharacterBase = await _context.Characters.ToListAsync();
        }
    }
}
