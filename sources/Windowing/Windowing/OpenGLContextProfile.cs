namespace Silk.NET.Windowing;

/// <summary>
/// Represents the context profile OpenGL should use.
/// </summary>
public enum OpenGLContextProfile
{
    /// <summary>
    /// An OpenGL context will not be created for this surface.
    /// </summary>
    None = 0,

    /// <summary>
    /// Use the platform default context profile e.g. <see cref="ES2" /> on mobile platforms, <see cref="Core" />
    /// otherwise.
    /// </summary>
    Default,

    /// <summary>
    /// Uses a core OpenGL context, which removes some deprecated functionality.
    /// </summary>
    Core,

    /// <summary>
    /// Uses a compatibility OpenGL context, allowing for some deprecated functionality. This should only ever be
    /// used for maintaining legacy code; no newly-written software should use this.
    /// </summary>
    Compatibility,

    /// <summary>
    /// Uses an OpenGLES 2+ profile.
    /// </summary>
    ES2,
}
