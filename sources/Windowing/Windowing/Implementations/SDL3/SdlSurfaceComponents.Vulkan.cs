// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Windowing.SDL3;

internal partial class SdlSurfaceComponents : ISurfaceVulkan
{
    bool ISurfaceVulkan.IsEnabled
    {
        get => IsVulkanConfigured;
        set => IsVulkanConfigured = value;
    }
    private bool IsVulkanConfigured
    {
        get;
        set
        {
            AssertUninit();
            field = value;
        }
    }

    private static void ThrowVulkanPrematureAccessException() =>
        throw new InvalidOperationException(
            "The Vulkan component cannot be accessed until ISurfaceApplication.Initialize<TSurface>(TSurface) "
                + "has finished executing, consider using the Surface.Created callback instead."
        );

    public unsafe ulong CreateSurface(IntPtr instance, Ptr allocator)
    {
        if (!IsSurfaceInitialized)
        {
            ThrowVulkanPrematureAccessException();
        }

        var ret = 0ul;
        if (!Sdl.VulkanCreateSurface(Handle, (void*)instance, allocator, ret.AsRef()))
        {
            Sdl.ThrowError();
        }

        return ret;
    }

    public Ptr2D<sbyte> GetRequiredExtensions(out uint count)
    {
        if (!IsSurfaceInitialized)
        {
            ThrowVulkanPrematureAccessException();
        }

        count = 0;
        var exts = Sdl.VulkanGetInstanceExtensions(count.AsRef());
        if (exts == nullptr)
        {
            Sdl.ThrowError();
        }

        return exts;
    }

    private void InitializeVulkan(uint props)
    {
        if (!IsVulkanConfigured)
        {
            return;
        }

        AddWindowCreateFlags(props, Sdl.WindowVulkan);
    }
}
