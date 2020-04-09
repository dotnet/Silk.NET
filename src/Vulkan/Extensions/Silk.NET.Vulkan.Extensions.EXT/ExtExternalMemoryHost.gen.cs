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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_external_memory_host")]
    public abstract unsafe partial class ExtExternalMemoryHost : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public abstract unsafe Result GetMemoryHostPointerProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public abstract Result GetMemoryHostPointerProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] ref T0 pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryHostPointerPropertiesEXT pMemoryHostPointerProperties) where T0 : unmanaged;

        public ExtExternalMemoryHost(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

