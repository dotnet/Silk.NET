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

namespace Silk.NET.Vulkan.Extensions.OHOS
{
    [Extension("VK_OHOS_external_memory")]
    public unsafe partial class OhosExternalMemory : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_OHOS_external_memory";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryNativeBufferOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryNativeBufferOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetNativeBufferInfoOHOS* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryNativeBufferOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryNativeBufferOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetNativeBufferInfoOHOS* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryNativeBufferOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryNativeBufferOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MemoryGetNativeBufferInfoOHOS pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint** pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryNativeBufferOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryNativeBufferOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MemoryGetNativeBufferInfoOHOS pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint* pBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetNativeBufferPropertiesOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetNativeBufferPropertiesOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NativeBufferPropertiesOHOS* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.NativeBufferPropertiesOhos);")]
        [NativeApi(EntryPoint = "vkGetNativeBufferPropertiesOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetNativeBufferPropertiesOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NativeBufferPropertiesOHOS pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetNativeBufferPropertiesOHOS", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetNativeBufferPropertiesOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NativeBufferPropertiesOHOS* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.NativeBufferPropertiesOhos);")]
        [NativeApi(EntryPoint = "vkGetNativeBufferPropertiesOHOS", Convention = CallingConvention.Winapi)]
        public partial Result GetNativeBufferPropertiesOhos([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly nint buffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NativeBufferPropertiesOHOS pProperties);

        public OhosExternalMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

