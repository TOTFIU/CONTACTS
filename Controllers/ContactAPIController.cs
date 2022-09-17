using Microsoft.AspNetCore.Mvc;
using WORK.DataBase;

namespace WORK.Controllers
{

    public class ContactAPIController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;

        public ContactAPIController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IActionResult> GetContact(Guid id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(x => x.Id == id);
            if (contact == null)
            {
                throw new ArgumentException("Wrong Id");
            }

            return this.Ok(contact);
        }
    }
}
