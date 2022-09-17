using WORK.DataBase;
using WORK.Domain;

namespace WORK
{
    public static class SampleData
    {
        public static void Initialize(DataBaseContext context)
        {
            if(!context.Contacts.Any())
            {
                context.Contacts.AddRange(
                    new Contact
                    {
                        Id = new Guid("B18F0400-BF23-4849-BF13-4D1D5D900226"),
                        Name = "Rayan Gosling",
                        MobilePhone = "88005553535",
                        JobTitle = "Driver",
                        BirthDate = new DateTime(1980, 11, 12),
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
