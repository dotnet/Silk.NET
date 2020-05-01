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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_fence_fd")]
    public abstract unsafe partial class KhrExternalFenceFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_fd";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public abstract unsafe Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceFdKHR")]
        public abstract Result GetFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR")]
        public abstract unsafe Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportFenceFdInfoKHR* pImportFenceFdInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceFdKHR")]
        public abstract Result ImportFenceF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportFenceFdInfoKHR pImportFenceFdInfo);

        public KhrExternalFenceFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

