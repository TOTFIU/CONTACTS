using Microsoft.VisualBasic;

namespace WORK.ViewModels
{
	public class GeneralContactViewModel
	{

		public List<ContactViewModel> Contacts { get; set; }
		public ContactViewModel AddModel { get; set; }
		public ContactViewModel EditModel { get; set; }
    }
}
