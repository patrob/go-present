using GoPresent.Api.Data;

namespace GoPresent.Api.Features.Presentations;

public interface IPresentationService
{
    Guid CreatePresentation(string name);
}

public class PresentationService(GoPresentDbContext context) : IPresentationService
{
    public Guid CreatePresentation(string name)
    {
        throw new NotImplementedException();
    }
}