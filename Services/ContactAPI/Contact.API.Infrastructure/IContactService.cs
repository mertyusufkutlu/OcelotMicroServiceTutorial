using Contact.API.Models;

namespace Contact.API.Infrastructure;

public interface IContactService
{
    public ContactDto GetContactById(int Id);
}