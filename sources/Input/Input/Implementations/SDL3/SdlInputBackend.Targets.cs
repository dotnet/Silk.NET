// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Silk.NET.Input.SDL3.Devices.Pointers.Targets;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3;

internal partial class SdlInputBackend
{
    private readonly List<SdlWindowTarget> _windowTargets = [];
    private readonly List<SdlDisplayTarget> _displayTargets = [];
    private delegate SdlArray<T> GetHandlesCallback<T>(ISdl sdl) where T : unmanaged;
    private readonly List<SdlBoundedPointerTarget> _tempTargets = new();

    private readonly GetHandlesCallback<WindowHandle> _getWindowHandles;
    private readonly GetHandlesCallback<SilkSdlDisplayHandle> _getDisplayHandles;
    private readonly Func<WindowHandle, uint?> _getWindowId;
    private readonly Func<SilkSdlDisplayHandle, uint?> _getDisplayId;

    private void UpdatePointerTargets()
    {
        PopulateTargets(_windowTargets, _sdl, _getWindowHandles, _getWindowId);
        PopulateTargets(_displayTargets, _sdl, _getDisplayHandles, _getDisplayId);
    }

    private uint? GetDisplayId(SilkSdlDisplayHandle x) => x.Id;

    private unsafe uint? GetWindowId(WindowHandle x)
    {
        if (x.Handle == null)
        {
            return null;
        }

        var windowId = _sdl.GetWindowID(x);
        if (windowId == 0)
        {
            SdlLog.Error("Failed to get window ID");
            return null;
        }

        return windowId;
    }

    internal bool TryGetWindowHandles(out SdlArray<WindowHandle> handles)
    {
        handles = GetWindowHandles(_sdl);
        return handles != nullptr;
    }

    internal static unsafe SdlArray<WindowHandle> GetWindowHandles(ISdl sdl)
    {
        var windowCount = 0;
        var windows = sdl.GetWindows(&windowCount);
        if (windows != null)
        {
            return new SdlArray<WindowHandle>(windows, windowCount, sdl, true);
        }

        SdlLog.Error("Failed to get window handles");
        return SdlArray<WindowHandle>.Null;

    }


    private static unsafe SdlArray<SilkSdlDisplayHandle> GetDisplayHandles(ISdl sdl)
    {
        var displayCount = 0;
        var displays = sdl.GetDisplays(&displayCount);
        if (displays != null)
        {
            return new SdlArray<SilkSdlDisplayHandle>(displays, displayCount, sdl);
        }

        SdlLog.Error("Failed to get display handles");
        return SdlArray<SilkSdlDisplayHandle>.Null;

    }

    private unsafe void PopulateTargets<T, THandle>(List<T> targets, ISdl sdl, GetHandlesCallback<THandle> getHandles,
        Func<THandle, uint?> getId)
        where THandle : unmanaged
        where T : SdlBoundedPointerTarget, ISdlBoundedPointerTarget<T, THandle>
    {
        using var handles = getHandles(sdl);
        if (handles == nullptr || handles.Count == 0)
        {
            ClearTargets<T, THandle>(targets);
            return;
        }

        Debug.Assert(_tempTargets.Count == 0, "Temp targets should be empty when populating targets");

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
            for(var j = 0; j < targets.Count; j++)
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
                var newTarget = T.Create(this, id.Value, handle);
                if (newTarget == null)
                {
                    InputLog.Error($"Failed to create target for handle {handle}");
                    continue;
                }

                target = newTarget;

                // add new target to temp targets to avoid including them in the search for removed targets
                _tempTargets.Add(newTarget);
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
        foreach (var target in _tempTargets)
        {
            targets.Add((T)target);
        }

        _tempTargets.Clear();
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

}
