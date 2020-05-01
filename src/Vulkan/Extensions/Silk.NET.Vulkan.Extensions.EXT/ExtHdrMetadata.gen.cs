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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_hdr_metadata")]
    public abstract unsafe partial class ExtHdrMetadata : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_hdr_metadata";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public abstract unsafe void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] HdrMetadataEXT* pMetadata);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        public abstract void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ref SwapchainKHR pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ref HdrMetadataEXT pMetadata);

        public ExtHdrMetadata(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

