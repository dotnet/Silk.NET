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
    [Extension("VK_KHR_external_memory_fd")]
    public abstract unsafe partial class KhrExternalMemoryFd : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public abstract unsafe Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryFdKHR")]
        public abstract Result GetMemoryF([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref MemoryGetFdInfoKHR pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out int pFd);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        public abstract unsafe Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryFdPropertiesKHR* pMemoryFdProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryFdPropertiesKHR")]
        public abstract Result GetMemoryFdProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryFdPropertiesKHR pMemoryFdProperties);

        public KhrExternalMemoryFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

