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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_display_native_hdr")]
    public unsafe partial class AmdDisplayNativeHdr : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_display_native_hdr";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetLocalDimmingAMD")]
        public partial void SetLocalDimming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapChain, [Count(Count = 0)] Bool32 localDimmingEnable);

        public AmdDisplayNativeHdr(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

