using WORK.Domain;
using WORK.ViewModels;

namespace WORK.Mapping
{
    public static class ContactMap
    {
        public static Contact ToDomain(this ContactViewModel model) =>
            new Contact
            {
                Id = model.Id,
                Name = model.Name,
                MobilePhone = model.MobilePhone,
                BirthDate = model.BirthDate,
                JobTitle = model.JobTitle
            };

        public static ContactViewModel ToViewModel(this Contact model) =>
    new ContactViewModel
    {
        Id = model.Id,
        Name = model.Name,
        MobilePhone = model.MobilePhone,
        BirthDate = model.BirthDate,
        JobTitle = model.JobTitle
    };
    }
}
