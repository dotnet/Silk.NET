// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_shared_presentable_image")]
    public unsafe partial class KhrSharedPresentableImage : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_shared_presentable_image";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSwapchainStatusKHR")]
        public partial Result GetSwapchainStatus([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        public KhrSharedPresentableImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

