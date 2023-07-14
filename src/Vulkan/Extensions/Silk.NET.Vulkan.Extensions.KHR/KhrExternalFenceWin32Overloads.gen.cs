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
    public static class KhrExternalFenceWin32Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, pGetWin32HandleInfo, out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImportFenceWin32HandleInfoKHR> pImportFenceWin32HandleInfo)
        {
            // SpanOverloader
            return thisApi.ImportFenceWin32Handle(device, in pImportFenceWin32HandleInfo.GetPinnableReference());
        }

    }
}

