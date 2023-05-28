using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleOverview.Models;
using PeopleOverview.Services;

namespace PeopleOverview.Pages
{
    public class PersonFormModel : PageModel
    {
        private readonly PersonService _service;
        [BindProperty]
        public Person NewPerson { get; set; } = default!;

        public PersonFormModel(PersonService service)
        {
            _service = service;
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || NewPerson == null)
            {
                return Page();
            }
            _service.AddPerson(NewPerson);
            return RedirectToAction("Get");
        }
        public void OnGet()
        {
            //return new RedirectToPageResult("/PersonList");
        }
    }
}
