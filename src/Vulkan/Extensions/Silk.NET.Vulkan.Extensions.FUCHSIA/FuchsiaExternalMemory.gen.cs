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

namespace Silk.NET.Vulkan.Extensions.FUCHSIA
{
    [Extension("VK_FUCHSIA_external_memory")]
    public unsafe partial class FuchsiaExternalMemory : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_FUCHSIA_external_memory";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetZirconHandleInfoFUCHSIA* pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandleFUCHSIA", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryZirconHandleFuchsia([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetZirconHandleInfoFUCHSIA pGetZirconHandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pZirconHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandlePropertiesFUCHSIA", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryZirconHandlePropertiesFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint zirconHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryZirconHandlePropertiesFUCHSIA* pMemoryZirconHandleProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryZirconHandleProperties = new(StructureType.MemoryZirconHandlePropertiesFuchsia);")]
        [NativeApi(EntryPoint = "vkGetMemoryZirconHandlePropertiesFUCHSIA", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryZirconHandlePropertiesFuchsia([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint zirconHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryZirconHandlePropertiesFUCHSIA pMemoryZirconHandleProperties);

        public FuchsiaExternalMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

