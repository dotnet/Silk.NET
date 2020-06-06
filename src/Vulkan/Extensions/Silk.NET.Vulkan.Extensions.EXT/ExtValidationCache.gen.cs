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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_validation_cache")]
    public unsafe partial class ExtValidationCache : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_validation_cache";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] ValidationCacheEXT* pValidationCache)
            => ImplCreateValidationCache(device, pCreateInfo, pAllocator, pValidationCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out ValidationCacheEXT pValidationCache)
            => ImplCreateValidationCache(device, pCreateInfo, pAllocator, pValidationCache);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyValidationCache(device, validationCache, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyValidationCache(device, validationCache, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] UIntPtr* pDataSize, [Count(Computed = "pDataSize")] void* pData)
            => ImplGetValidationCacheData(device, validationCache, pDataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref UIntPtr pDataSize, [Count(Computed = "pDataSize")] ref T0 pData) where T0 : unmanaged
            => ImplGetValidationCacheData<T0>(device, validationCache, pDataSize, pData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ValidationCacheEXT* pSrcCaches)
            => ImplMergeValidationCaches(device, dstCache, srcCacheCount, pSrcCaches);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Computed = "srcCacheCount"), Flow(FlowDirection.In)] ref ValidationCacheEXT pSrcCaches)
            => ImplMergeValidationCaches(device, dstCache, srcCacheCount, pSrcCaches);

        public ExtValidationCache(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

