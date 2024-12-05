// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal unsafe class SdlSurfaceLifecycle(SdlSurface surface) : IDetachedSurfaceLifecycle
{
    /// <summary>
    /// The function used to initialize the <see cref="ISurfaceApplication" /> attached to the surface.
    /// This is not used for detached surfaces.
    /// </summary>
    private static delegate* <SdlSurface> _attachedLifecycleInit;

    /// <summary>
    /// The first attached surface.
    /// </summary>
    private static SdlSurface? _attachedLifecycleRootSurface;

    /// <summary>
    /// The <see cref="AppIterateFunc"/> for
    /// <see cref="Sdl.EnterAppMainCallbacks(int,Ref2D{sbyte},AppInitFunc,AppIterateFunc,AppEventFunc,AppQuitFunc)"/> -
    /// used on attached surfaces. This executes the tick.
    /// </summary>
    public static AppIterateFunc AppIterate => (delegate* unmanaged<void*, AppResult>)&AttachedTick;
    public static AppEventFunc AppEvent =>
        (delegate* unmanaged<void*, Event*, AppResult>)&AttachedEvent;
    public static AppQuitFunc AppQuit =>
        (delegate* unmanaged<void*, AppResult, void>)&AttachedDispose;

    public Surface Surface => surface;

    public static AppInitFunc AppInit<T>()
        where T : ISurfaceApplication
    {
        // Work around unmanaged functions not being allowed to be generic.
        _attachedLifecycleInit = &CoreInit<T>;
        return (delegate* unmanaged<void**, int, sbyte**, AppResult>)&AttachedLifecycleInit;
    }

    [UnmanagedCallersOnly]
    private static AppResult AttachedLifecycleInit(void** appstate, int argc, sbyte** argv)
    {
        DebugPrint();
        _attachedLifecycleRootSurface = _attachedLifecycleInit();
        _attachedLifecycleInit = null;
        return AppResult.Continue;
    }

    public static SdlSurface CoreInit<T>()
        where T : ISurfaceApplication
    {
        if (T.WindowClass is { } wc && !Sdl.SetHint(Sdl.HintAppId, wc)) // haha toilet
        {
            Sdl.ThrowError();
        }

        return CoreInit<T>(null);
    }

    public static SdlSurface CoreInit<T>(SdlSurface? parent)
        where T : ISurfaceApplication
    {
        DebugPrint();
        var surface = new SdlSurface { Parent = parent };
        surface.PreInitialize();
        T.Initialize(surface);
        surface.Initialize();
        return surface;
    }

    [UnmanagedCallersOnly]
    private static AppResult AttachedTick(void* appstate) =>
        // TODO TickOptions.IsEventDriven: https://github.com/libsdl-org/SDL/issues/11387
        _attachedLifecycleRootSurface is not null
        && CoreTick(_attachedLifecycleRootSurface)
            ? _attachedLifecycleRootSurface.IsTerminating
                ? AppResult.Success
                : AppResult.Continue
            : AppResult.Failure;

    private static bool CoreTick(SdlSurface surface)
    {
        surface.OnTick();
        if (surface.Window?.IsCloseRequested ?? false)
        {
            surface.Terminate();
        }

        return true;
    }

    public void Tick()
    {
        Event @event = default;
        if (
            Surface.TickOptions.IsEventDriven
                ? Sdl.WaitEvent(@event.AsRef())
                : Sdl.PollEvent(@event.AsRef())
        )
        {
            SdlEventProcessor.DeliverEvent(ref @event);
        }

        CoreTick(surface);
    }

    [UnmanagedCallersOnly]
    private static AppResult AttachedEvent(void* appstate, Event* @event)
    {
        if (_attachedLifecycleRootSurface is not null)
        {
            CoreEvent(_attachedLifecycleRootSurface, ref *@event);
        }
        else
        {
            DebugPrint($"got {(EventType)@event->Type} but no surface attached.");
        }

        return AppResult.Continue;
    }

    private static void CoreEvent(SdlSurface surface, ref Event @event)
    {
        DebugPrint($"got {(EventType)@event.Type}, dispatching to surface {surface}.");
        SdlEventProcessor.DeliverEvent(ref @event);
    }

    [UnmanagedCallersOnly]
    private static void AttachedDispose(void* appstate, AppResult lastResult)
    {
        DebugPrint();
        if (_attachedLifecycleRootSurface is not null)
        {
            CoreDispose(_attachedLifecycleRootSurface);
        }

        _attachedLifecycleRootSurface = null;
    }

    private static void CoreDispose(SdlSurface surface) => surface.Dispose();

    public void Dispose() => CoreDispose(surface);
}
