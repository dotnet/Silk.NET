namespace Silk.NET.SilkTouch.Mods.Metadata;

/// <summary>
/// Provides information about where a piece of metadata was retrieved from.
/// </summary>
[Flags]
public enum MetadataSources
{
    /// <summary>
    /// No information about the metadata source is available.
    /// </summary>
    None = 0,

    /// <summary>
    /// The metadata was obtained from the child symbol.
    /// </summary>
    Child = 1 << 0,

    /// <summary>
    /// The metadata was obtained from the parent symbol.
    /// </summary>
    Parent = 1 << 1,

    /// <summary>
    /// The metadata was obtained from the parent symbol as a fallback
    /// because the child symbol did not have any metadata.
    /// </summary>
    ParentFallback = 1 << 2,
}
