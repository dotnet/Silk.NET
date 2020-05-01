// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_deferred_host_operations")]
    public abstract unsafe partial class KhrDeferredHostOperations : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_deferred_host_operations";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR")]
        public abstract unsafe Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DeferredOperationKHR* pDeferredOperation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDeferredOperationKHR")]
        public abstract Result CreateDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DeferredOperationKHR pDeferredOperation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDeferredOperationJoinKHR")]
        public abstract Result DeferredOperationJoin([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR")]
        public abstract unsafe void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDeferredOperationKHR")]
        public abstract void DestroyDeferredOperation([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationMaxConcurrencyKHR")]
        public abstract uint GetDeferredOperationMaxConcurrency([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeferredOperationResultKHR")]
        public abstract Result GetDeferredOperationResult([Count(Count = 0)] Device device, [Count(Count = 0)] DeferredOperationKHR operation);

        public KhrDeferredHostOperations(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

