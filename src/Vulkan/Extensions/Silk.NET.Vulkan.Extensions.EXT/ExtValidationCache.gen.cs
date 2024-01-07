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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_validation_cache")]
    public unsafe partial class ExtValidationCache : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_validation_cache";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ValidationCacheCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ValidationCacheEXT* pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateValidationCache([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ValidationCacheCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ValidationCacheEXT pValidationCache);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyValidationCacheEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyValidationCache([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] nuint* pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetValidationCacheData([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] void* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetValidationCacheDataEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetValidationCacheData<T0>([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT validationCache, [Count(Count = 0)] ref nuint pDataSize, [Count(Parameter = "pDataSize")] ref T0 pData) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ValidationCacheEXT* pSrcCaches);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkMergeValidationCachesEXT", Convention = CallingConvention.Winapi)]
        public partial Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Count = 0)] uint srcCacheCount, [Count(Parameter = "srcCacheCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ValidationCacheEXT pSrcCaches);

        /// <summary>To be documented.</summary>
        public unsafe Result MergeValidationCaches([Count(Count = 0)] Device device, [Count(Count = 0)] ValidationCacheEXT dstCache, [Count(Parameter = "srcCacheCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ValidationCacheEXT> pSrcCaches)
        {
            // ImplicitCountSpanOverloader
            return MergeValidationCaches(device, dstCache, (uint) pSrcCaches.Length, in pSrcCaches.GetPinnableReference());
        }

        public ExtValidationCache(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

