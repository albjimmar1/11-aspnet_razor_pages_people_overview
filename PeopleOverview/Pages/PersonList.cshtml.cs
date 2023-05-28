using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PeopleOverview.Models;
using PeopleOverview.Services;

namespace PeopleOverview.Pages
{
    public class PersonListModel : PageModel
    {
        private readonly PersonService _service;
        public IList<Person> PersonList { get;set; } = default!;

        public PersonListModel(PersonService service)
        {
            _service = service;
        }
        public void OnGet()
        {
            PersonList = _service.GetPeople();
        }
        public IActionResult OnPostDelete(int id)
        {
            _service.DeletePerson(id);
            return RedirectToAction("Get");
        }
    }
}
