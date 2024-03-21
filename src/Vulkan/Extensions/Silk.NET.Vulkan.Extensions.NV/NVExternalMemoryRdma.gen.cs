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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_rdma")]
    public unsafe partial class NVExternalMemoryRdma : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_memory_rdma";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryRemoteAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryRemoteAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryRemoteAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryRemoteAddress<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetRemoteAddressInfoNV* pMemoryGetRemoteAddressInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pAddress) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryRemoteAddressNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryRemoteAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* pAddress);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryRemoteAddressNV", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryRemoteAddress<T0>([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetRemoteAddressInfoNV pMemoryGetRemoteAddressInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 pAddress) where T0 : unmanaged;

        public NVExternalMemoryRdma(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

