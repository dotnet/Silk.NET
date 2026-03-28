namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Represents a name trimmer.
/// </summary>
public interface INameTrimmer
{
    /// <summary>
    /// Trims prefixes from the given constituent names within the given container.
    /// </summary>
    /// <param name="context">The arguments.</param>
    public void Trim(NameTrimmerContext context);
}
