// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceVulkan
{
    bool ISurfaceVulkan.IsEnabled
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    ulong ISurfaceVulkan.CreateSurface(IntPtr instance, Ptr allocator) =>
        throw new NotImplementedException();

    Ptr2D<sbyte> ISurfaceVulkan.GetRequiredExtensions(out uint count) =>
        throw new NotImplementedException();
}
