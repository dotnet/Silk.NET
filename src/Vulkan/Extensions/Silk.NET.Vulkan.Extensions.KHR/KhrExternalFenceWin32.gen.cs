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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_fence_win32")]
    public unsafe partial class KhrExternalFenceWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_win32";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle)
            => ImplGetFenceWin32Handle(device, pGetWin32HandleInfo, pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetFenceWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref FenceGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle)
            => ImplGetFenceWin32Handle(device, pGetWin32HandleInfo, pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result ImportFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo)
            => ImplImportFenceWin32Handle(device, pImportFenceWin32HandleInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkImportFenceWin32HandleKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result ImportFenceWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ImportFenceWin32HandleInfoKHR pImportFenceWin32HandleInfo)
            => ImplImportFenceWin32Handle(device, pImportFenceWin32HandleInfo);

        public KhrExternalFenceWin32(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

