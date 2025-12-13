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
    [Extension("VK_EXT_external_memory_metal")]
    public unsafe partial class ExtExternalMemoryMetal : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_external_memory_metal";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetMetalHandleInfoEXT* pGetMetalHandleInfo, [Count(Count = 0)] void** pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetMetalHandleInfoEXT* pGetMetalHandleInfo, [Count(Count = 0)] ref void* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MemoryGetMetalHandleInfoEXT pGetMetalHandleInfo, [Count(Count = 0)] void** pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandleEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MemoryGetMetalHandleInfoEXT pGetMetalHandleInfo, [Count(Count = 0)] ref void* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandlePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryMetalHandlePropertiesEXT* pMemoryMetalHandleProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryMetalHandleProperties = new(StructureType.MemoryMetalHandlePropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandlePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryMetalHandlePropertiesEXT pMemoryMetalHandleProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandlePropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryMetalHandleProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] ref T0 pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryMetalHandlePropertiesEXT* pMemoryMetalHandleProperties) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryMetalHandleProperties = new(StructureType.MemoryMetalHandlePropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetMemoryMetalHandlePropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryMetalHandleProperties<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] ref T0 pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryMetalHandlePropertiesEXT pMemoryMetalHandleProperties) where T0 : unmanaged;

        public ExtExternalMemoryMetal(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

