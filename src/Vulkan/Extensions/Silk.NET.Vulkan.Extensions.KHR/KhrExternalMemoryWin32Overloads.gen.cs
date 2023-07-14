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
    public static class KhrExternalMemoryWin32Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, pGetWin32HandleInfo, out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryWin32Handle(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryWin32HandleProperties = new(StructureType.MemoryWin32HandlePropertiesKhr);")]
        public static unsafe Result GetMemoryWin32HandleProperties(this KhrExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryWin32HandlePropertiesKHR> pMemoryWin32HandleProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32HandleProperties(device, handleType, handle, out pMemoryWin32HandleProperties.GetPinnableReference());
        }

    }
}

