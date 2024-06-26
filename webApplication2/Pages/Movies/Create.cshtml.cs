﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using webApplication2.Data;
using webApplication2.Models;

namespace webApplication2.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly webApplication2.Data.webApplication2Context _context;

        public CreateModel(webApplication2.Data.webApplication2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //ADDS MOVIE DATA AND SAVES CHANGES

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index"); //RE-DIRECTS 
        }
    }
}
