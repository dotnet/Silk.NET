namespace Silk.NET.Core;

/// <summary>
/// The UIKit platform-specific handles.
/// </summary>
/// <param name="Window"><c>UIWindow</c>.</param>
/// <param name="Framebuffer">OpenGL framebuffer handle.</param>
/// <param name="ColorBuffer">OpenGL color buffer handle.</param>
/// <param name="ResolveFramebuffer">OpenGL resolve framebuffer handle.</param>
public readonly record struct UIKitPlatformInfo(
    nint Window,
    uint Framebuffer,
    uint ColorBuffer,
    uint ResolveFramebuffer
);
