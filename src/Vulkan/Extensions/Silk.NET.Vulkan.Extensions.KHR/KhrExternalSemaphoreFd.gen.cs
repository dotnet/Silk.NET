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
    [Extension("VK_KHR_external_semaphore_fd")]
    public abstract unsafe partial class KhrExternalSemaphoreFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_fd";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR")]
        public abstract unsafe Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreFdKHR")]
        public abstract Result GetSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR")]
        public abstract unsafe Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportSemaphoreFdInfoKHR* pImportSemaphoreFdInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreFdKHR")]
        public abstract Result ImportSemaphoreF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo);

        public KhrExternalSemaphoreFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

