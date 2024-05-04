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
    [Extension("VK_KHR_deferred_host_operations")]
    public unsafe partial class KhrDeferredHostOperations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_deferred_host_operations";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeferredOperationKHR pDeferredOperation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public partial Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeferredOperationKHR pDeferredOperation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDeferredOperationJoinKHR", Convention = CallingConvention.Winapi)]
        public partial Result DeferredOperationJoin([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR", Convention = CallingConvention.Winapi)]
        public partial void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR", Convention = CallingConvention.Winapi)]
        public partial uint GetDeferredOperationMaxConcurrency([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationResultKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetDeferredOperationResult([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        public KhrDeferredHostOperations(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

