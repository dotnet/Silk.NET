// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceChildren
{
    private List<SdlSurface>? _children;

    public void Spawn<T>()
        where T : ISurfaceApplication
    {
        _children ??= new List<SdlSurface>(1);
        var child = SdlSurfaceLifecycle.CoreInit<T>(surface);
        child.Terminating += _ =>
        {
            _children?.Remove(child);
            if (_children?.Count == 0)
            {
                _children = null;
            }
        };
        _children.Add(child);
    }

    public void TickChildren()
    {
        if (_children is null)
        {
            return;
        }

        foreach (var child in _children)
        {
            child.OnTick();
        }
    }
}
