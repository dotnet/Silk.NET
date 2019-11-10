// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.GLFW;

namespace Silk.NET.Windowing.Common
{
    public interface IVulkanWindow
    {
        VkHandle CreateSurface<T>(VkHandle instance, ref T allocator) where T:unmanaged;
    }
}
