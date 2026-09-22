// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Silk.NET.Input.SDL3.DataStructures;
using Silk.NET.Input.SDL3.Devices.Pointers;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.Maths;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal unsafe partial class SdlInputBackend
{
    // private static uint? GetDisplayId(SilkSdlDisplayHandle x) => x.Id;

    private static uint? GetWindowId(WindowHandle x)
    {
        if (x.Handle == null)
        {
            return null;
        }

        var windowId = SDL.Sdl.GetWindowID(x);
        if (windowId == 0)
        {
            SdlLog.Error("Failed to get window ID");
            return null;
        }

        return windowId;
    }

    internal bool TryGetWindowHandles(out SdlArray<WindowHandle> handles)
    {
        handles = GetWindowHandles(Sdl);
        return handles != nullptr;
    }

    private static SdlArray<WindowHandle> GetWindowHandles(ISdl sdl)
    {
        var windowCount = 0;
        var windows = sdl.GetWindows(&windowCount);
        if (windows != null)
        {
            return new SdlArray<WindowHandle>(windows, windowCount, sdl, consumerCanDispose: true);
        }

        SdlLog.Error("Failed to get window handles");
        return SdlArray<WindowHandle>.Null;
    }

    /*

    private delegate SdlArray<T> GetHandlesCallback<T>(ISdl sdl) where T : unmanaged;


    private readonly List<SdlBoundedPointerTarget> _tempTargets = new();


    private void UpdatePointerTargets()
    {
        //PopulateTargets(_sdlWindowTargets, Sdl, GetWindowHandles, GetWindowId, _tempTargets);
        //PopulateTargets(_sdlDisplayTargets, Sdl, GetDisplayHandles, GetDisplayId, _tempTargets);
    }

    private static SdlArray<SilkSdlDisplayHandle> GetDisplayHandles(ISdl sdl)
    {
        var displayCount = 0;
        var displays = sdl.GetDisplays(&displayCount);
        if (displays != null)
        {
            return new SdlArray<SilkSdlDisplayHandle>(displays, displayCount, sdl, consumerCanDispose: true);
        }

        SdlLog.Error("Failed to get display handles");
        return SdlArray<SilkSdlDisplayHandle>.Null;
    }

    private static void PopulateTargets<T, THandle>(List<T> targets, ISdl sdl, GetHandlesCallback<THandle> getHandles,
        Func<THandle, uint?> getId, List<SdlBoundedPointerTarget> tempTargets)
        where THandle : unmanaged
        where T : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<T, THandle>
    {
        using var handles = getHandles(sdl);
        if (handles == nullptr || handles.Count == 0)
        {
            ClearTargets<T, THandle>(targets);
            return;
        }

        Debug.Assert(tempTargets.Count == 0, "Temp targets should be empty when populating targets");

        Span<uint?> ids = stackalloc uint?[handles.Count];

        for (var i = 0; i < handles.Count; i++)
        {
            ref var handle = ref handles[i];
            var id = ids[i] = getId(handle);
            if (id == null)
            {
                // ??? we were given an invalid handle
                continue;
            }

            // check if we already have a target for this handle
            // note: not using 'FindIndex' here to avoid closure allocation
            var targetIndex = -1;
            for (var j = 0; j < targets.Count; j++)
            {
                if (targets[j].Id == id.Value)
                {
                    targetIndex = j;
                    break;
                }
            }

            T target;
            if (targetIndex == -1)
            {
                // create a new one
                var newTarget = T.Create(sdl, id.Value, handle);
                if (newTarget == null)
                {
                    InputLog.Error($"Failed to create target for handle {handle}");
                    continue;
                }

                target = newTarget;

                // add new target to temp targets to avoid including them in the search for removed targets
                tempTargets.Add(newTarget);
            }
            else
            {
                target = targets[targetIndex];
            }

            target.UpdateBounds();
        }

        // check for removed targets
        for (var i = targets.Count - 1; i >= 0; --i)
        {
            var target = targets[i];
            if (!ids.Contains(target.Id))
            {
                target.Dispose();
                targets.RemoveAt(i);
            }
        }

        // add new targets to the list
        foreach (var target in tempTargets)
        {
            targets.Add((T)target);
        }

        tempTargets.Clear();
    }

    private static void ClearTargets<T, THandle>(List<T> targets)
        where T : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<T, THandle>
        where THandle : unmanaged
    {
        foreach (var target in targets)
        {
            target.Dispose();
        }

        targets.Clear();
    }

    */

    public bool TryGetVirtualTouchpad(nint ownerId, int touchpadId, ulong sdlTimestamp, long timestamp,
        [NotNullWhen(true)] out SdlTouchSurface? device, [NotNullWhen(true)] out ISimulatedPointerTarget? target)
    {
        var hash = HashCode.Combine(ownerId, touchpadId);
        ulong id = Unsafe.As<int, uint>(ref hash);
        if (!TryGetOrCreateDevice(id, timestamp, sdlTimestamp, out device, isSimulated: true))
        {
            target = null;
            return false;
        }

        target = device.ApplySimulatedTarget(CreateSimulatedTarget);

#if DEBUG
        Debug.Assert(device.IsSimulated);
        Debug.Assert(device.Targets.Count == 1);
        Debug.Assert(device.Targets[0] == target);
#endif
        return true;

        static ISimulatedPointerTarget CreateSimulatedTarget(ISdl backend) =>
            new SimulatedPointerTarget(backend);
    }


    internal bool TryGetOrCreatePointerTargetForWindow(WindowHandle window,
        [NotNullWhen(true)] out SdlWindowTarget? target)
    {
        if (window.Handle is null)
        {
            target = null;
            return false;
        }

        var id = GetWindowId(window);

        if (id is null)
        {
            SdlLog.Error("Failed to get id for window");
            target = null;
            return false;
        }

        if (TryGetPointerTargetForWindowId(id.Value, _sdlWindowTargets, out target))
        {
            return true;
        }

        target = AddWindowTargetWithId(Sdl, _sdlWindowTargets, id.Value, window);
        return true;
    }

    private bool TryGetOrCreatePointerTargetForWindow(uint windowId,
        [NotNullWhen(true)] out SdlWindowTarget? target)
    {
        if (TryGetPointerTargetForWindowId(windowId, _sdlWindowTargets, out target))
        {
            return true;
        }

        var id = Sdl.GetWindowFromID(windowId);
        if (id.Handle is null)
        {
            SdlLog.Error("Failed to get id for window");
            target = null;
            return false;
        }


        var handle = Sdl.GetWindowFromID(windowId);
        if (handle.Handle is null)
        {
            SdlLog.Error("Failed to get id for new window target");
            target = null;
            return false;
        }

        target = AddWindowTargetWithId(Sdl, _sdlWindowTargets, windowId, handle);
        return true;
    }

    private static SdlWindowTarget AddWindowTargetWithId(ISdl backend, List<SdlWindowTarget> targets,
        uint id, WindowHandle window)
    {
        var newTarget = SdlWindowTarget.Create(backend, id, window);
        newTarget.UpdateBounds();
        targets.Add(newTarget);
        return newTarget;
    }

    private static bool TryGetPointerTargetForWindowId(uint id, List<SdlWindowTarget> targets,
        [NotNullWhen(true)] out SdlWindowTarget? target)
    {
        if (id == 0)
        {
            target = null;
            return false;
        }

        for (var i = 0; i < targets.Count; ++i)
        {
            var t = targets[i];
            if (t.Id == id)
            {
                target = t;
                return true;
            }
        }

        target = null;
        return false;
    }


    private void OnWindowMove(in WindowEvent evt, long timestamp)
    {
        if (!TryGetOrCreatePointerTargetForWindow(evt.WindowID, out var target))
        {
            return;
        }

        var bounds = target.Bounds;
        if (!target.Move(new Vector2D<float>(evt.Data1, evt.Data2)))
        {
            return;
        }

        SdlLog.Debug("Window move");

        for (var index = 0; index < _deviceRegistry.Devices.Count; index++)
        {
            if (_deviceRegistry.Devices[index] is SdlPointerDevice pointerDevice)
            {
                pointerDevice.TargetChanged(target, timestamp, evt.Timestamp, oldBounds: bounds);
            }
        }
    }


    private void OnWindowDestroyed(in WindowEvent evt, long timestamp)
    {
        if (!TryGetOrCreatePointerTargetForWindow(evt.WindowID, out var target))
        {
            return;
        }

        SdlLog.Debug("Window destroyed");
        for (var index = 0; index < _deviceRegistry.Devices.Count; index++)
        {
            if (_deviceRegistry.Devices[index] is SdlPointerDevice pointerDevice)
            {
                pointerDevice.TargetDestroyed(target, timestamp, evt.Timestamp);
            }
        }
    }

    private void OnWindowUnclearMotion(in WindowEvent evt, long timestamp)
    {
        if (!TryGetOrCreatePointerTargetForWindow(evt.WindowID, out var target))
        {
            return;
        }

        var previous = target.Bounds;
        if (!target.UpdateBounds())
        {
            return; // nothing has changed
        }

        SdlLog.Debug("Window unclear motion");

        for (var index = 0; index < _deviceRegistry.Devices.Count; index++)
        {
            if (_deviceRegistry.Devices[index] is SdlPointerDevice pointerDevice)
            {
                pointerDevice.TargetChanged(target, timestamp, evt.Timestamp, oldBounds: previous);
            }
        }
    }

    private void OnWindowResized(in WindowEvent evt, long timestamp)
    {
        if (!TryGetOrCreatePointerTargetForWindow(evt.WindowID, out var target))
        {
            return;
        }

        if (!target.Resize(new Vector2D<float>(evt.Data1, evt.Data2)))
        {
            return;
        }
        for (var index = 0; index < _deviceRegistry.Devices.Count; index++)
        {
            if (_deviceRegistry.Devices[index] is SdlPointerDevice pointerDevice)
            {
                pointerDevice.TargetChanged(target, timestamp, evt.Timestamp, oldBounds: target.Bounds);
            }
        }
    }

    private readonly List<SdlWindowTarget> _sdlWindowTargets = new();
    // private readonly List<SdlDisplayTarget> _sdlDisplayTargets = new();
}
