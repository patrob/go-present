using Microsoft.AspNetCore.Mvc;

namespace GoPresent.Api.Features.Presentations;

[ApiController]
[Route("api/[controller]")]
public class PresentationsController(IPresentationService presentationService) : ControllerBase
{
    [HttpPost]
    public Guid CreatePresentation([FromBody] string name)
    {
        return presentationService.CreatePresentation(name);
    }

    [HttpDelete("{id:guid}")]
    public void DeletePresentation(Guid id)
    {
        throw new NotImplementedException();
    }
}