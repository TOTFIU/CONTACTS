using Microsoft.AspNetCore.Mvc;
using WORK.DataBase;
using WORK.Domain;
using WORK.Mapping;
using WORK.ViewModels;

namespace WORK.Controllers
{
    public class ContactController : Controller
    {
        private readonly DataBaseContext _dbContext;

        public ContactController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetModels()
        {
            var contacts = _dbContext.Contacts.Select(x => x.ToViewModel()).ToList();
            return View(new GeneralContactViewModel { Contacts = contacts });
        }

        [HttpPost]
        public async Task<IActionResult> AddModel(GeneralContactViewModel model)
        {
           

            _dbContext.Contacts.Add(model.AddModel.ToDomain());
            await _dbContext.SaveChangesAsync(new CancellationToken());
            return RedirectToAction("GetModels");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteModels(Guid id)
        {
            var contact = _dbContext.Contacts.FirstOrDefault(x => x.Id == id);
            if (contact == null)
            {
                throw new ArgumentException("Wrong Id");
            }

            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync(new CancellationToken());
            return RedirectToAction("GetModels");
        }
        [HttpPost]
        public async Task<IActionResult> EditModel(GeneralContactViewModel model)
        {
            
                foreach (var orig in _dbContext.Contacts)
                {
                    if(orig.Id == model.EditModel.Id)
                    {
                        orig.Name = model.EditModel.Name;
                        orig.MobilePhone = model.EditModel.MobilePhone;
                        orig.BirthDate = model.EditModel.BirthDate;
                        orig.JobTitle = model.EditModel.JobTitle;
                        
                    }
                }

            await _dbContext.SaveChangesAsync(new CancellationToken());
            return RedirectToAction("GetModels");           
        }
    }

}
