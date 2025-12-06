namespace Silk.NET.Windowing;

using Silk.NET.Maths;

/// <summary>
/// The OpenGL component of a <see cref="Surface" />. The <see cref="IGLContext" /> methods can only be executed once
/// <see cref="ISurfaceApplication.Initialize{TSurface}" /> has executed.
/// </summary>
/// <remarks>
/// These objects may be shared with child windows created using <see cref="ISurfaceChildren" /> and vice versa i.e.
/// this object can be shared between all surfaces that share a common ancestor (the "root surface"). Beyond that, these
/// objects are not guaranteed to be valid across surfaces. This allows one event handler to enact changes on multiple
/// surfaces. This is important for <see cref="SharedContext" /> purposes.
/// </remarks>
public interface ISurfaceOpenGL : IGLContext
{
    /// <summary>
    /// Gets or sets a value indicating whether OpenGL support is enabled for this surface. Setting
    /// <see cref="Profile" /> to a value other than <see cref="OpenGLContextProfile.None" /> will automatically set
    /// this property to <c>true</c>, and likewise toggling the value assigned to this property will change the value of
    /// <see cref="Profile" />.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    // Included for consistency with Vulkan.
    bool IsEnabled
    {
        get => Profile != OpenGLContextProfile.None;
        set =>
            Profile = value
                ? Profile == OpenGLContextProfile.None
                    ? OpenGLContextProfile.Default
                    : Profile
                : OpenGLContextProfile.None;
    }

    /// <summary>
    /// Preferred depth buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// Setting this property will automatically set <see cref="Profile" /> to
    /// <see cref="OpenGLContextProfile.Default" /> if it is currently <see cref="OpenGLContextProfile.None" />.
    /// </remarks>
    int? PreferredDepthBufferBits { get; set; }

    /// <summary>
    /// Preferred stencil buffer bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> to use the system default.
    /// </remarks>
    int? PreferredStencilBufferBits { get; set; }

    /// <summary>
    /// Preferred red, green, blue, and alpha bits of the window's framebuffer.
    /// </summary>
    /// <remarks>
    /// Pass <c>null</c> or <c>-1</c> for any of the channels to use the system default.
    /// </remarks>
    Vector4D<int>? PreferredBitDepth { get; set; }

    /// <summary>
    /// Preferred number of samples for multi-sample anti-aliasing.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    int? PreferredSampleCount { get; set; }

    /// <summary>
    /// The API version to use.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    Version32? Version { get; set; }

    /// <summary>
    /// Flags used to create the OpenGL context.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    OpenGLContextFlags Flags { get; set; }

    /// <summary>
    /// The profile the OpenGL context should use. If <see cref="OpenGLContextProfile.None" /> is used, the OpenGL
    /// component is effectively disabled, allowing for other graphics APIs/components to be used. If any of the other
    /// properties on this class are set while this property is <see cref="OpenGLContextProfile.None" />, this property
    /// shall automatically be populated with the value <see cref="OpenGLContextProfile.Default" />.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method. If the value is
    /// <see cref="OpenGLContextProfile.Default" />, this shall be replaced with the actual value upon exit from
    /// <see cref="ISurfaceApplication.Initialize{TSurface}" />.
    /// </remarks>
    OpenGLContextProfile Profile { get; set; }

    /// <summary>
    /// Gets a value indicating whether the current configuration is supported (e.g. version number). If
    /// <see cref="Profile" /> is not <see cref="OpenGLContextProfile.None" /> and this property is <c>true</c>, the
    /// OpenGL context shall be created and accessible upon exit from
    /// <see cref="ISurfaceApplication.Initialize{TSurface}" />.
    /// </summary>
    bool IsSupported { get; }

    /// <summary>
    /// Gets or sets a value indicating whether the platform should automatically <see cref="IGLContext.SwapBuffers" />
    /// after <see cref="Surface.Render" />. Defaults to <c>true</c>.
    /// </summary>
    /// <remarks>
    /// This can be set at any point throughout the surface's execution.
    /// </remarks>
    bool ShouldSwapAutomatically { get; set; }

    /// <summary>
    /// Gets or sets the context with which this context should share resources.
    /// </summary>
    /// <remarks>
    /// This can only be set during the <see cref="ISurfaceApplication.Initialize{TSurface}" /> method.
    /// </remarks>
    IGLContext? SharedContext { get; set; }
}
