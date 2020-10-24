// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_external_memory_host")]
    public unsafe partial class ExtExternalMemoryHost : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_external_memory_host";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public unsafe partial Result GetMemoryHostPointerProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public unsafe partial Result GetMemoryHostPointerProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryHostPointerPropertiesEXT pMemoryHostPointerProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public unsafe partial Result GetMemoryHostPointerProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] ref T0 pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] MemoryHostPointerPropertiesEXT* pMemoryHostPointerProperties) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryHostPointerPropertiesEXT")]
        public partial Result GetMemoryHostPointerProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] ref T0 pHostPointer, [Count(Count = 0), Flow(FlowDirection.Out)] out MemoryHostPointerPropertiesEXT pMemoryHostPointerProperties) where T0 : unmanaged;

        public ExtExternalMemoryHost(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

