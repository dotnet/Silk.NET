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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrMapMemory2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result MapMemory2(this KhrMapMemory2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryMapInfo> pMemoryMapInfo, [Count(Count = 0)] void** ppData)
        {
            // SpanOverloader
            return thisApi.MapMemory2(device, in pMemoryMapInfo.GetPinnableReference(), ppData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result MapMemory2(this KhrMapMemory2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryMapInfo> pMemoryMapInfo, [Count(Count = 0)] ref void* ppData)
        {
            // SpanOverloader
            return thisApi.MapMemory2(device, in pMemoryMapInfo.GetPinnableReference(), ref ppData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result UnmapMemory2(this KhrMapMemory2 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryUnmapInfo> pMemoryUnmapInfo)
        {
            // SpanOverloader
            return thisApi.UnmapMemory2(device, in pMemoryUnmapInfo.GetPinnableReference());
        }

    }
}

