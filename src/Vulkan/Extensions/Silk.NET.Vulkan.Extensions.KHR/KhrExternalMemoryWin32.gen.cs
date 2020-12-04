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
    [Extension("VK_KHR_external_memory_win32")]
    public unsafe partial class KhrExternalMemoryWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_win32";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR")]
        public partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out IntPtr pHandle);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
        public unsafe partial Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] IntPtr handle, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR")]
        public partial Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] IntPtr handle, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties);

        public KhrExternalMemoryWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

