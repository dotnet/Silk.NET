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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_private_data")]
    public abstract unsafe partial class ExtPrivateData : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_private_data";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public abstract unsafe Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        public abstract Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        public abstract unsafe void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        public abstract void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        public abstract unsafe void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        public abstract void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetPrivateDataEXT")]
        public abstract Result SetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0)] ulong data);

        public ExtPrivateData(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

