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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_validation_cache")]
    public abstract unsafe partial class ExtValidationCache : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_validation_cache";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public abstract unsafe Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public abstract Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        public abstract unsafe void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        public abstract void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public abstract unsafe Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public abstract Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        public abstract unsafe Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ValidationCacheEXT* pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        public abstract Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ref ValidationCacheEXT pSrcCaches);

        public ExtValidationCache(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

