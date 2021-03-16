// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public static class StructExtensions
    {
        public static SurfaceKHR ToSurface(this VkNonDispatchableHandle handle)
        {
            return new SurfaceKHR {Handle = handle.Handle};
        }

        public static VkHandle ToHandle(this Instance instance)
        {
            return new VkHandle(instance.Handle);
        }
    }
}
