// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PrivateDataSlot pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PrivateDataSlotCreateInfo* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PrivateDataSlot pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrivateDataSlotCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrivateDataSlotCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PrivateDataSlot pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrivateDataSlotCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PrivateDataSlot* pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreatePrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreatePrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PrivateDataSlotCreateInfo pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PrivateDataSlot pPrivateDataSlot);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyPrivateDataSlotEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyPrivateDataSlot([Count(Count = 0)] Device device, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPrivateDataEXT", Convention = CallingConvention.Winapi)]
        public partial void GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetPrivateDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot, [Count(Count = 0)] ulong data);

        /// <summary>To be documented.</summary>
        public unsafe ulong GetPrivateData([Count(Count = 0)] Device device, [Count(Count = 0)] ObjectType objectType, [Count(Count = 0)] ulong objectHandle, [Count(Count = 0)] PrivateDataSlot privateDataSlot)
        {
            // NonKhrReturnTypeOverloader
            GetPrivateData(device, objectType, objectHandle, privateDataSlot, out ulong silkRet);
            return silkRet;
        }

        public ExtPrivateData(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

