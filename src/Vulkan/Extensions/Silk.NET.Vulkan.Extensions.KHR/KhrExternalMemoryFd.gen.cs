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
    [Extension("VK_KHR_external_memory_fd")]
    public unsafe partial class KhrExternalMemoryFd : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_fd";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd)
            => ImplGetMemoryF(device, pGetFdInfo, pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd)
            => ImplGetMemoryF(device, pGetFdInfo, pFd);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryFdPropertiesKHR* pMemoryFdProperties)
            => ImplGetMemoryFdProperties(device, handleType, fd, pMemoryFdProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryFdPropertiesKHR pMemoryFdProperties)
            => ImplGetMemoryFdProperties(device, handleType, fd, pMemoryFdProperties);

        public KhrExternalMemoryFd(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

