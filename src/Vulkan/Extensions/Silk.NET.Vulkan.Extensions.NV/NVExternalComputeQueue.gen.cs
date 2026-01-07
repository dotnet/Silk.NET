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
    [Extension("VK_NV_external_compute_queue")]
    public unsafe partial class NVExternalComputeQueue : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_compute_queue";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalComputeQueueNV pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ExternalComputeQueueCreateInfoNV* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalComputeQueueNV pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ExternalComputeQueueCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ExternalComputeQueueCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalComputeQueueNV pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ExternalComputeQueueCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalComputeQueueNV* pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public partial Result CreateExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ExternalComputeQueueCreateInfoNV pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalComputeQueueNV pExternalQueue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyExternalComputeQueueNV", Convention = CallingConvention.Winapi)]
        public partial void DestroyExternalComputeQueue([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExternalComputeQueueDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetExternalComputeQueueData([Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] ExternalComputeQueueDataParamsNV* @params, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExternalComputeQueueDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetExternalComputeQueueData<T0>([Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] ExternalComputeQueueDataParamsNV* @params, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExternalComputeQueueDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetExternalComputeQueueData([Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] ref ExternalComputeQueueDataParamsNV @params, [Count(Count = 0)] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetExternalComputeQueueDataNV", Convention = CallingConvention.Winapi)]
        public partial void GetExternalComputeQueueData<T0>([Count(Count = 0)] ExternalComputeQueueNV externalQueue, [Count(Count = 0)] ref ExternalComputeQueueDataParamsNV @params, [Count(Count = 0)] ref T0 pData) where T0 : unmanaged;

        public NVExternalComputeQueue(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

