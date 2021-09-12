namespace Silk.NET.Statiq.TableOfContents
{
    public record TableOfContentsModel
    (
        TableOfContentsElement Root,
        TableOfContentsElement? Node
    );
}