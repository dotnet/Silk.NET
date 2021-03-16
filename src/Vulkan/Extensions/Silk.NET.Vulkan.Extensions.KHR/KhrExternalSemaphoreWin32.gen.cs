// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_semaphore_win32")]
    public unsafe partial class KhrExternalSemaphoreWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_win32";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public unsafe partial Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] nint* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public unsafe partial Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out nint pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public unsafe partial Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] nint* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetSemaphoreWin32HandleKHR")]
        public partial Result GetSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in SemaphoreGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out nint pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        public unsafe partial Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkImportSemaphoreWin32HandleKHR")]
        public partial Result ImportSemaphoreWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ImportSemaphoreWin32HandleInfoKHR pImportSemaphoreWin32HandleInfo);

        public KhrExternalSemaphoreWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

