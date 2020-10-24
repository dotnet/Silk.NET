// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_fence_fd")]
    public unsafe partial class KhrExternalFenceFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_fd";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public unsafe partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public partial Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in FenceGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR")]
        public unsafe partial Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportFenceFdInfoKHR* pImportFenceFdInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR")]
        public partial Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImportFenceFdInfoKHR pImportFenceFdInfo);

        public KhrExternalFenceFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

