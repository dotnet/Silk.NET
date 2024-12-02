// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal class SdlSurface : Surface, IDisposable
{
    private static uint _emptyEvent;
    private static BreakneckLock _staticLock;
    private bool _isTerminating;

    public SdlSurface() => Impl = new SdlSurfaceComponents(this);

    // This is its own separate class so that users don't inadvertently rely on type system details (i.e. use
    // `surface is ISurfaceWindow` instead of `surface.Window`)
    private SdlSurfaceComponents Impl { get; }
    internal SdlSurface? Parent { get; set; }
    public override ISurfaceOpenGL? OpenGL => SdlSurfaceComponents.IsOpenGLEnabled ? Impl : null;
    public override ISurfaceWindow? Window => SdlSurfaceComponents.IsWindowEnabled ? Impl : null;
    public override ISurfaceDisplay? Display => SdlSurfaceComponents.IsDisplayEnabled ? Impl : null;
    public override ISurfaceVulkan? Vulkan => SdlSurfaceComponents.IsVulkanEnabled ? Impl : null;
    public override ISurfaceChildren? Children =>
        SdlSurfaceComponents.IsChildrenEnabled ? Impl : null;
    public override ISurfaceScale? Scale => SdlSurfaceComponents.IsScaleEnabled ? Impl : null;
    public override Vector2 DrawableSize => Impl.DrawableSize;
    public override bool IsTerminating => _isTerminating;
    public override event Action<SurfaceResizeEvent>? DrawableSizeChanged;
    public override event Action<SurfaceLifecycleEvent>? Created;
    public override event Action<SurfaceLifecycleEvent>? Terminating;
    public override event Action<SurfaceLifecycleEvent>? Pausing;
    public override event Action<SurfaceLifecycleEvent>? Resuming;
    public override event Action<SurfaceLifecycleEvent>? LowMemory;
    public override SurfaceTickOptions TickOptions
    {
        get => default;
        set =>
            throw new NotImplementedException(
                "Event-driven main loops are currently not implemented in the underlying library in use by Silk.NET. "
                    + "See the upstream issue: https://github.com/libsdl-org/SDL/issues/11387"
            );
    }

    public void PreInitialize() => Impl.PreInitializeSurface();

    public void Initialize()
    {
        Impl.InitializeSurface();
        Created?.Invoke(new SurfaceLifecycleEvent(this));
    }

    public override void Continue()
    {
        var locked = false;
        _staticLock.Enter(ref locked); // <-- locked is always true, not sure why it's needed.
        if (_emptyEvent == 0)
        {
            _emptyEvent = Sdl.RegisterEvents(1);
        }

        _staticLock.Exit();
        var @event = new Event { Type = _emptyEvent };
        if (!Sdl.PushEvent(@event.AsRef()))
        {
            Sdl.ThrowError();
        }
    }

    protected internal override void OnTick()
    {
        Impl.TickChildren();
        base.OnTick();
    }

    public override void Terminate()
    {
        var prev = _isTerminating;
        _isTerminating = true;
        if (!prev && _isTerminating)
        {
            Terminating?.Invoke(new SurfaceLifecycleEvent(this));
        }
    }

    public override bool TryGetPlatformInfo<TPlatformInfo>(
        [NotNullWhen(true)] out TPlatformInfo? info
    )
        where TPlatformInfo : default => throw new NotImplementedException();

    public void Dispose() => Impl.Dispose();
}
