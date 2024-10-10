using Silk.NET.Core.Loader;

namespace Silk.NET.Core;

/// <summary>
/// Represents an OpenGL context.
/// </summary>
public interface IGLContext : INativeContext, IDisposable
{
    /// <summary>
    /// Whether the context is current on this thread.
    /// </summary>
    bool IsCurrent { get; }

    /// <summary>
    /// Sets the number of vertical blanks to wait for until the next backbuffer swap.
    /// </summary>
    /// <param name="interval">The number of frames.</param>
    void SwapInterval(int interval);

    /// <summary>
    /// Swaps the backbuffer to present the contents to the window.
    /// </summary>
    void SwapBuffers();

    /// <summary>
    /// Makes the context current.
    /// </summary>
    void MakeCurrent();

    /// <summary>
    /// Clears the context from this thread.
    /// </summary>
    /// <remarks>
    /// This should check whether <c>GL.ThisThread</c> has this as current as well.
    /// </remarks>
    void Clear();
}
