namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents a name processor.
/// </summary>
public interface INameProcessor
{
    /// <summary>
    /// Process and transform the names within the given container.
    /// </summary>
    public void ProcessNames(NameProcessorContext context);
}
