using System.Drawing;

namespace GoPresent.Api.Features.Presentations.Entities;

public record SlideObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public SlideObjectTypeEnum SlideObjectType { get; set; }
    public string Text { get; set; } = string.Empty;
}