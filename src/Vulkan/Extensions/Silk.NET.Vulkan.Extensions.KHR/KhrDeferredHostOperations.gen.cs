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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_deferred_host_operations")]
    public unsafe partial class KhrDeferredHostOperations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_deferred_host_operations";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation)
            => ImplCreateDeferredOperation(device, pAllocator, pDeferredOperation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeferredOperationKHR pDeferredOperation)
            => ImplCreateDeferredOperation(device, pAllocator, pDeferredOperation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDeferredOperationJoinKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result DeferredOperationJoin([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation)
            => ImplDeferredOperationJoin(device, operation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDeferredOperation(device, operation, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDeferredOperation(device, operation, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDeferredOperationMaxConcurrency([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation)
            => ImplGetDeferredOperationMaxConcurrency(device, operation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationResultKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetDeferredOperationResult([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation)
            => ImplGetDeferredOperationResult(device, operation);

        public KhrDeferredHostOperations(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

