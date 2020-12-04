// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Core.Native;

namespace Silk.NET.Vulkan
{
    public static class StructExtensions
    {
        public static SurfaceKHR ToSurface(this VkNonDispatchableHandle handle)
        {
<<<<<<< HEAD
            return new SurfaceKHR {Handle = handle.Handle};
=======
            return new SurfaceKHR { Handle = (ulong) handle.Handle.ToInt64() };
>>>>>>> master
        }

        public static VkHandle ToHandle(this Instance instance)
        {
            return new VkHandle(instance.Handle);
        }
    }
}
