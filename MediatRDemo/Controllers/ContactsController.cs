using MediatR;
using MediatRDemo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatRDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ContactsController : ControllerBase
{
    private IMediator mediator;

    public ContactsController(IMediator mediator) => this.mediator = mediator;


    [HttpGet("{Id}")]
    public async Task<ContactsContext.Contact> GetContact([FromRoute]Query query) => await this.mediator.Send(query);



    #region Nested Classes

    public class Query : IRequest<ContactsContext.Contact>
    {
        public int Id { get; set; }
    }

    public class ContactHandler : IRequestHandler<Query, ContactsContext.Contact>
    {
        private ContactsContext db;

        public ContactHandler(ContactsContext db) => this.db = db;

        public Task<ContactsContext.Contact> Handle(Query request, CancellationToken cancellationToken)
        {
            return this.db.Contacts.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
        }
    }

    #endregion
}