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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_map_memory2")]
    public unsafe partial class KhrMapMemory2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_map_memory2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryMapInfoKHR* pMemoryMapInfo, [Count(Count = 0)] void** ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryMapInfoKHR* pMemoryMapInfo, [Count(Count = 0)] ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryMapInfoKHR pMemoryMapInfo, [Count(Count = 0)] void** ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMapMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryMapInfoKHR pMemoryMapInfo, [Count(Count = 0)] ref void* ppData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result UnmapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryUnmapInfoKHR* pMemoryUnmapInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkUnmapMemory2KHR", Convention = CallingConvention.Winapi)]
        public partial Result UnmapMemory2([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryUnmapInfoKHR pMemoryUnmapInfo);

        public KhrMapMemory2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

