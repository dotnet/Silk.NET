// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_hdr_metadata")]
    public unsafe partial class ExtHdrMetadata : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_hdr_metadata";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] SwapchainKHR* pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] HdrMetadataEXT* pMetadata)
            => ImplSetHdrMetadata(device, swapchainCount, pSwapchains, pMetadata);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetHdrMetadataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SetHdrMetadata([Count(Count = 0)] Device device, [Count(Count = 0)] uint swapchainCount, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ref SwapchainKHR pSwapchains, [Count(Computed = "swapchainCount"), Flow(FlowDirection.In)] ref HdrMetadataEXT pMetadata)
            => ImplSetHdrMetadata(device, swapchainCount, pSwapchains, pMetadata);

        public ExtHdrMetadata(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

