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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_display_native_hdr")]
    public abstract unsafe partial class AmdDisplayNativeHdr : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_display_native_hdr";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetLocalDimmingAMD")]
        public abstract void SetLocalDimming([Count(Count = 0)] Device device, [Count(Count = 0)] SwapchainKHR swapChain, [Count(Count = 0)] Bool32 localDimmingEnable);

        public AmdDisplayNativeHdr(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

