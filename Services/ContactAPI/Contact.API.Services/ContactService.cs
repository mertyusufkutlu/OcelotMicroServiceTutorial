using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services;

public class ContactService : IContactService
{
    public ContactDto GetContactById(int id)
    {
        return new ContactDto()
        {
            Id = id,
            FirstName = "Mert Yusuf",
            LastName = "Kutlu"
        };
    }
}