namespace Silk.NET.Windowing;

/// <summary>
/// Represents the context profile OpenGL should use.
/// </summary>
public enum OpenGLContextProfile
{
    /// <summary>
    /// Uses a core OpenGL context, which removes some deprecated functionality.
    /// </summary>
    Core = 0,

    /// <summary>
    /// Uses a compatability OpenGL context, allowing for some deprecated functionality. This should only ever be
    /// used for maintaining legacy code; no newly-written software should use this.
    /// </summary>
    Compatability,

    /// <summary>
    /// Uses an OpenGLES 2+ profile.
    /// </summary>
    ES2
}