using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/[controller]")]
public class ClientsController : ControllerBase
{
    private readonly YourDbContext _dbContext;

    public ClientsController(YourDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET: api/Clients
    [HttpGet]
    public ActionResult<IEnumerable<Client>> GetClients()
    {
        var clients = _dbContext.Clients.ToList(); // Use the correct property name "Clients"
        return Ok(clients);
    }

    // POST: api/Clients
    [HttpPost]
    public ActionResult<Client> AddClient(Client client)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _dbContext.Clients.Add(client); // Use the correct property name "Clients"
        _dbContext.SaveChanges();

        // Return the newly added client with 201 Created status
        return CreatedAtAction(nameof(GetClient), new { id = client.ID }, client);
    }

    // DELETE: api/Clients/5
    [HttpDelete("{id}")]
    public IActionResult DeleteClient(int id)
    {
        var client = _dbContext.Clients.FirstOrDefault(c => c.ID == id); // Use the correct property name "Clients"
        if (client == null)
        {
            return NotFound();
        }

        _dbContext.Clients.Remove(client); // Use the correct property name "Clients"
        _dbContext.SaveChanges();

        return NoContent();
    }

    // Additional actions for filtering clients can be added here

    // Helper method to retrieve a single client
    [NonAction]
    public ActionResult<Client> GetClient(int id)
    {
        var client = _dbContext.Clients.FirstOrDefault(c => c.ID == id); // Use the correct property name "Clients"
        return client != null ? Ok(client) : NotFound();
    }
}
