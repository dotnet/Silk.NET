using Silk.NET.Core.Loader;

namespace Silk.NET.Core;

/// <summary>
/// Represents an OpenGL context.
/// </summary>
public interface IGLContext : INativeContext
{
    /// <summary>
    /// Whether the context is current on this thread.
    /// </summary>
    bool IsCurrent { get; set; }

    /// <summary>
    /// The number of vertical blanks to wait for before sending another frame.
    /// </summary>
    int SwapInterval { get; set; }

    /// <summary>
    /// Swaps the backbuffer to present the contents to the window.
    /// </summary>
    void SwapBuffers();
}
