using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RP_EF_Maria.Models;

namespace RP_EF_Maria.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly StoreContext _context;

        public IndexModel(StoreContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get; set; } = default!;

        //get user input through the query string (url)

        [BindProperty(SupportsGet = true)]
        public string Query { get; set; } = default!;



        [BindProperty(SupportsGet = true)]
        public string DateChosen { get; set; } = default!;


        [BindProperty(SupportsGet = true)]
        public bool BeforeDateChosen { get; set; } = false;


        [BindProperty(SupportsGet = true)]
        public bool IncludeSearch { get; set; } = false;




        public async Task OnGetAsync()
        {

            IQueryable<Game> games; //store games query in a list


            if (Query != null)
            {
                //if title query is not null, then filter the games list by the query
                games = _context.Game.Where(g => g.Title.Contains(Query));
            }
            else
            {
                //if title query is null, then return all games
                games = _context.Game;
            }

            //add to query(further filter) to get gaes released in the last 5 years
            // games = games.Where(g => g.Release > DateTime.Now.AddYears(-5));


            if (IncludeSearch)
            {
                if (BeforeDateChosen)
                {
                    games = games.Where(g => g.Release <= DateTime.Parse(DateChosen));
                }
                else
                {
                    games = games.Where(g => g.Release > DateTime.Parse(DateChosen));
                }

            }
            //do the query, store in a list (do it asynchronasly, so other program segmetns can run)
            Game = await games.ToListAsync();

            //render the page
            Page();
        }

    }
}

