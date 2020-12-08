// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    [Extension("VK_EXT_validation_cache")]
    public unsafe partial class ExtValidationCache : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_validation_cache";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        public partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        public unsafe partial void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        public partial void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public unsafe partial Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public unsafe partial Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public unsafe partial Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        public partial Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        public unsafe partial Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ValidationCacheEXT* pSrcCaches);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        public partial Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] in ValidationCacheEXT pSrcCaches);

        public ExtValidationCache(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

