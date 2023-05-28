using PeopleOverview.Data;
using PeopleOverview.Models;

namespace PeopleOverview.Services
{
    public class PersonService
    {
        private readonly PersonContext _context = default!;

        public PersonService(PersonContext context)
        {
            _context = context;
        }

        public IList<Person> GetPeople()
        {
            if (_context.People != null)
            {
                return _context.People.ToList();
            }
            return new List<Person>();
        }

        public void AddPerson(Person person)
        {
            if (_context.People != null)
            {
                _context.People.Add(person);
                _context.SaveChanges();
            }
        }

        public void DeletePerson(int id)
        {
            if (_context.People != null)
            {
                var person = _context.People.Find(id);
                if (person != null)
                {
                    _context.People.Remove(person);
                    _context.SaveChanges();
                }
            }
        }
    }
}