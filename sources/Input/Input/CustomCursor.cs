namespace Silk.NET.Input;

/// <summary>
/// Represents a custom image for a mouse cursor.
/// </summary>
public readonly ref struct CustomCursor
{
    /// <summary>
    /// The number of pixels in the X axis.
    /// </summary>
    public int Width { get; init; }

    /// <summary>
    /// The number of pixels in the Y axis.
    /// </summary>
    public int Height { get; init; }

    /// <summary>
    /// The row-major 32-bit RGBA pixel data (i.e. 8 bits for each colour component).
    /// </summary>
    public ReadOnlySpan<int> Data { get; init; } // Rgba32
}
