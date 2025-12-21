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

    // equality operator override
    /// <summary>
    /// Value-based equality operator
    /// </summary>
    /// <remarks>Note that this operator does not consider reference equality</remarks>
    public static bool operator ==(CustomCursor left, CustomCursor right) => left.Width == right.Width &&
                                                                             left.Height == right.Height &&
                                                                             left.Data.Length == right.Data.Length &&
                                                                             left.Data.SequenceEqual(right.Data);

    /// <summary>
    /// Value-based inequality operator
    /// </summary>
    /// <remarks>Note that this operator does not consider reference equality</remarks>
    public static bool operator !=(CustomCursor left, CustomCursor right) => !(left == right);
}
