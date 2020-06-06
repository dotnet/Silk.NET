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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_private_data")]
    public unsafe partial class ExtPrivateData : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_private_data";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PrivateDataSlotCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] PrivateDataSlotEXT* pPrivateDataSlot)
            => ImplCreatePrivateDataSlot(device, pCreateInfo, pAllocator, pPrivateDataSlot);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref PrivateDataSlotCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out PrivateDataSlotEXT pPrivateDataSlot)
            => ImplCreatePrivateDataSlot(device, pCreateInfo, pAllocator, pPrivateDataSlot);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyPrivateDataSlot(device, privateDataSlot, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyPrivateDataSlot(device, privateDataSlot, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] ulong* pData)
            => ImplGetPrivateData(device, objectType, objectHandle, privateDataSlot, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0), Flow(FlowDirection.Out)] out ulong pData)
            => ImplGetPrivateData(device, objectType, objectHandle, privateDataSlot, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetPrivateDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlotEXT privateDataSlot, [Count(Count = 0)] ulong data)
            => ImplSetPrivateData(device, objectType, objectHandle, privateDataSlot, data);

        public ExtPrivateData(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

