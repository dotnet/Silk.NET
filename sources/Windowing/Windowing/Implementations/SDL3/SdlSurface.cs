// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal class SdlSurface : Surface, IDisposable
{
    private bool _isTerminating;

    public SdlSurface() => Impl = new SdlSurfaceComponents(this);

    // This is its own separate class so that users don't inadvertently rely on type system details (i.e. use
    // `surface is ISurfaceWindow` instead of `surface.Window`)
    internal SdlSurfaceComponents Impl { get; }
    internal SdlSurface? Parent { get; set; }
    public override ISurfaceOpenGL? OpenGL => SdlSurfaceComponents.IsOpenGLEnabled ? Impl : null;
    public override ISurfaceWindow? Window => SdlSurfaceComponents.IsWindowEnabled ? Impl : null;
    public override ISurfaceDisplay? Display => SdlSurfaceComponents.IsDisplayEnabled ? Impl : null;
    public override ISurfaceVulkan? Vulkan => SdlSurfaceComponents.IsVulkanEnabled ? Impl : null;
    public override ISurfaceChildren? Children =>
        SdlSurfaceComponents.IsChildrenEnabled ? Impl : null;
    public override ISurfaceScale? Scale => SdlSurfaceComponents.IsScaleEnabled ? Impl : null;
    public override Vector2 DrawableSize => _drawableSize = Impl.DrawableSize;
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

    public void PreInitialize()
    {
        DebugPrint();
        Impl.PreInitializeSurface();
    }

    public void Initialize()
    {
        DebugPrint();
        Impl.InitializeSurface();
        DebugPrint("Raising Created...");
        Created?.Invoke(new SurfaceLifecycleEvent(this));
    }

    public override void Continue() => SdlEventProcessor.ContinueEvents();

    protected internal override void OnTick()
    {
        Impl.TickChildren();
        base.OnTick();
    }

    public override void Terminate()
    {
        DebugPrint();
        var prev = _isTerminating;
        _isTerminating = true;
        if (!prev && _isTerminating)
        {
            DebugPrint("Recursing into children...");
            Impl.TerminateChildren();
            DebugPrint("Raising Terminating...");
            Terminating?.Invoke(new SurfaceLifecycleEvent(this));
        }
    }

    public override bool TryGetPlatformInfo<TPlatformInfo>(
        [NotNullWhen(true)] out TPlatformInfo? info
    )
        where TPlatformInfo : default
    {
        info = default;
        if (!Impl.IsSurfaceInitialized)
        {
            return false;
        }

        if (typeof(TPlatformInfo) == typeof(SdlPlatformInfo))
        {
            info = (TPlatformInfo)(object)new SdlPlatformInfo(Impl.Handle, Sdl.Instance);
            return true;
        }

        var props = Sdl.GetWindowProperties(Impl.Handle);
        if (typeof(TPlatformInfo) == typeof(CocoaPlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new CocoaPlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(props, Sdl.PropWindowCocoaWindowPointer, nullptr)
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(EGLPlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new EGLPlatformInfo(
                        (nint)Sdl.EGLGetCurrentDisplay(),
                        (nint)Sdl.EGLGetWindowSurface(Impl.Handle)
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(UIKitPlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new UIKitPlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowUikitWindowPointer,
                                nullptr
                            ),
                        (uint)
                            Sdl.GetNumberProperty(
                                props,
                                Sdl.PropWindowUikitOpenglFramebufferNumber,
                                0
                            ),
                        (uint)
                            Sdl.GetNumberProperty(
                                props,
                                Sdl.PropWindowUikitOpenglRenderbufferNumber,
                                0
                            ),
                        (uint)
                            Sdl.GetNumberProperty(
                                props,
                                Sdl.PropWindowUikitOpenglResolveFramebufferNumber,
                                0
                            )
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(VivantePlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new VivantePlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowVivanteDisplayPointer,
                                nullptr
                            ),
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowVivanteWindowPointer,
                                nullptr
                            )
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(WaylandPlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new WaylandPlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowWaylandDisplayPointer,
                                nullptr
                            ),
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowWaylandDisplayPointer,
                                nullptr
                            )
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(Win32PlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new Win32PlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(props, Sdl.PropWindowWin32HwndPointer, nullptr),
                        (nint)Sdl.GetPointerProperty(props, Sdl.PropWindowWin32HdcPointer, nullptr),
                        (nint)
                            Sdl.GetPointerProperty(
                                props,
                                Sdl.PropWindowWin32InstancePointer,
                                nullptr
                            )
                    );
            Sdl.ClearError();
            return true;
        }

        if (typeof(TPlatformInfo) == typeof(X11PlatformInfo))
        {
            info = (TPlatformInfo)
                (object)
                    new X11PlatformInfo(
                        (nint)
                            Sdl.GetPointerProperty(props, Sdl.PropWindowX11DisplayPointer, nullptr),
                        (nint)Sdl.GetNumberProperty(props, Sdl.PropWindowX11WindowNumber, 0)
                    );
            Sdl.ClearError();
            return true;
        }

        return false;
    }

    internal void OnPausing()
    {
        DebugPrint("Raising Pausing...");
        Pausing?.Invoke(new SurfaceLifecycleEvent(this));
    }

    internal void OnResuming()
    {
        DebugPrint("Raising Resuming...");
        Resuming?.Invoke(new SurfaceLifecycleEvent(this));
    }

    internal void OnLowMemory()
    {
        DebugPrint("Raising LowMemory...");
        LowMemory?.Invoke(new SurfaceLifecycleEvent(this));
    }

    private Vector2 _drawableSize;

    internal void OnDrawableSizeChanged()
    {
        var oldDrawableSize = _drawableSize;
        var newDrawableSize = DrawableSize;
        if (oldDrawableSize != newDrawableSize)
        {
            DebugPrint("Raising DrawableSizeChanged...");
            DrawableSizeChanged?.Invoke(
                new SurfaceResizeEvent(this, oldDrawableSize, newDrawableSize)
            );
        }
    }

    public void Dispose() => Impl.Dispose();

    public override unsafe string ToString() =>
        $"{base.ToString()} (0x{(nint)Impl.Handle.Handle:X})";
}
