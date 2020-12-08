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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_private_data")]
    public unsafe partial class ExtPrivateData : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_private_data";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        public unsafe partial void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        public partial void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        public unsafe partial void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        public partial void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetPrivateDataEXT")]
        public partial Result SetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0)] ulong data);

        public ExtPrivateData(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

