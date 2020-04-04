// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_shared_presentable_image")]
    public abstract unsafe partial class KhrSharedPresentableImage : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetSwapchainStatusKHR")]
        public abstract Result GetSwapchainStatus([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapchain);

        public KhrSharedPresentableImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

