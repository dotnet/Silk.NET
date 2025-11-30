namespace Silk.NET.Windowing;

/// <summary>
/// Represents flags related to the OpenGL context.
/// </summary>
[Flags]
public enum OpenGlContextFlags
{
    /// <summary>
    /// No flags enabled.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Enables debug context; debug contexts provide more debugging info, but can run slower.
    /// </summary>
    Debug = 1 << 0,

    /// <summary>
    /// Enables forward compatibility; this context won't support anything marked as deprecated in the current
    /// version.
    /// </summary>
    /// <remarks>On OpenGL contexts older than 3.0, this flag does nothing.</remarks>
    ForwardCompatible = 1 << 1,
}
