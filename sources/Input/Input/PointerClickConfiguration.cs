namespace Silk.NET.Input;

/// <summary>
/// Denotes the configuration for recognising <see cref="Pointers.DoubleClick"/> events apart from single
/// <see cref="Pointers.Click"/> events.
/// </summary>
/// <param name="DoubleClickTime">
/// The maximum time in milliseconds between two consecutive clicks to count as a double click.
/// </param>
/// <param name="DoubleClickRange">
/// The maximum distance in pixels between two consecutive clicks to count as a double click.
/// </param>
public record struct PointerClickConfiguration(int DoubleClickTime, float DoubleClickRange)
{
    /// <summary>
    /// Gets the default configuration.
    /// </summary>
    public static PointerClickConfiguration Default => new(500, 4);
}
