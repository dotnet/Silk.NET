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
    [Extension("VK_KHR_external_fence_win32")]
    public abstract unsafe partial class KhrExternalFenceWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_win32";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceWin32HandleKHR")]
        public abstract unsafe Result GetFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceWin32HandleKHR")]
        public abstract Result GetFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceWin32HandleKHR")]
        public abstract unsafe Result ImportFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceWin32HandleKHR")]
        public abstract Result ImportFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo);

        public KhrExternalFenceWin32(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

