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
    [Extension("VK_KHR_external_semaphore_win32")]
    public abstract unsafe partial class KhrExternalSemaphoreWin32 : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public abstract unsafe Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public abstract Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref SemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        public abstract unsafe Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        public abstract Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo);

        public KhrExternalSemaphoreWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

