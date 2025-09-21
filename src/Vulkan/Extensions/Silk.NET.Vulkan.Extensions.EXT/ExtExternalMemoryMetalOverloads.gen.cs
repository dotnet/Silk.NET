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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtExternalMemoryMetalOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryMetalHandle(this ExtExternalMemoryMetal thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetMetalHandleInfoEXT> pGetMetalHandleInfo, [Count(Count = 0)] void** pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryMetalHandle(device, in pGetMetalHandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryMetalHandle(this ExtExternalMemoryMetal thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetMetalHandleInfoEXT> pGetMetalHandleInfo, [Count(Count = 0)] ref void* pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryMetalHandle(device, in pGetMetalHandleInfo.GetPinnableReference(), ref pHandle);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryMetalHandleProperties = new(StructureType.MemoryMetalHandlePropertiesExt);")]
        public static unsafe Result GetMemoryMetalHandleProperties(this ExtExternalMemoryMetal thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] void* pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryMetalHandlePropertiesEXT> pMemoryMetalHandleProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryMetalHandleProperties(device, handleType, pHandle, out pMemoryMetalHandleProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryMetalHandleProperties<T0>(this ExtExternalMemoryMetal thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryMetalHandlePropertiesEXT* pMemoryMetalHandleProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryMetalHandleProperties(device, handleType, ref pHandle.GetPinnableReference(), pMemoryMetalHandleProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryMetalHandleProperties = new(StructureType.MemoryMetalHandlePropertiesExt);")]
        public static unsafe Result GetMemoryMetalHandleProperties<T0>(this ExtExternalMemoryMetal thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] Span<T0> pHandle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryMetalHandlePropertiesEXT> pMemoryMetalHandleProperties) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetMemoryMetalHandleProperties(device, handleType, ref pHandle.GetPinnableReference(), out pMemoryMetalHandleProperties.GetPinnableReference());
        }

    }
}

