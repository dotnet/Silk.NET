// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;

namespace Silk.NET.Vulkan
{
    public static class StructExtensions
    {
        public static SurfaceKHR ToSurface(this VkHandle handle)
        {
            return new SurfaceKHR { Handle = (ulong) handle.Handle.ToInt64() };
        }

        public static VkHandle ToHandle(this Instance instance)
        {
            return new VkHandle(instance.Handle);
        }
    }
}
