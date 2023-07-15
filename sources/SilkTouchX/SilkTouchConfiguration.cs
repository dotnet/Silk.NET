namespace SilkTouchX;

/// <summary>
/// Represents the configuration for a single generation job in SilkTouch.
/// </summary>
public class SilkTouchConfiguration
{
    /// <summary>
    /// The response files to read.
    /// </summary>
    public required string[] ClangSharpResponseFiles { get; set; }

    /// <summary>
    /// The mods to load for generation. If there are no mods, this tool is basically equivalent to running
    /// ClangSharpPInvokeGenerator directly.
    /// </summary>
    public string[]? Mods { get; set; }
}
