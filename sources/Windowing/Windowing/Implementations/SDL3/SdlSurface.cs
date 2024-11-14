// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Silk.NET.Windowing.SDL3;

internal class SdlSurface : Surface
{
    private SdlSurfaceComponents _components;

    public SdlSurface() => _components = new SdlSurfaceComponents(this);

    public override ISurfaceOpenGL? OpenGL => _components.IsOpenGLEnabled ? _components : null;
    public override ISurfaceWindow? Window => _components.IsWindowEnabled ? _components : null;
    public override ISurfaceDisplay? Display => _components.IsDisplayEnabled ? _components : null;
    public override ISurfaceVulkan? Vulkan => _components.IsVulkanEnabled ? _components : null;
    public override ISurfaceChildren? Children =>
        _components.IsChildrenEnabled ? _components : null;
    public override ISurfaceScale? Scale => _components.IsScaleEnabled ? _components : null;
    public override Vector2 DrawableSize { get; }
    public override event Action<SurfaceResizeEvent>? DrawableSizeChanged;
    public override event Action<SurfaceLifecycleEvent>? Created;
    public override event Action<SurfaceLifecycleEvent>? Terminating;
    public override event Action<SurfaceLifecycleEvent>? Pausing;
    public override event Action<SurfaceLifecycleEvent>? Resuming;
    public override event Action<SurfaceLifecycleEvent>? LowMemory;
    public override SurfaceTickOptions TickOptions { get; set; }

    public override void Continue() => throw new NotImplementedException();

    public override void Terminate() => throw new NotImplementedException();

    public override bool TryGetPlatformInfo<TPlatformInfo>(
        [NotNullWhen(true)] out TPlatformInfo? info
    )
        where TPlatformInfo : default => throw new NotImplementedException();
}
