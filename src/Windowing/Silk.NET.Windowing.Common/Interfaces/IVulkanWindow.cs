// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// A Vulkan window.
    /// </summary>
    [Obsolete("IVulkanWindow is deprecated and will be removed in 2.0, use IWindow.VkSurface instead.")]
    public interface IVulkanWindow : IVulkanView, IWindow
    {
    }
}
