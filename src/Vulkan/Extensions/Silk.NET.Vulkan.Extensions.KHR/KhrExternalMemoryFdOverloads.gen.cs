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
    public static class KhrExternalMemoryFdOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, pGetFdInfo, out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, in pGetFdInfo.GetPinnableReference(), pFd);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MemoryGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, in pGetFdInfo.GetPinnableReference(), out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryFdProperties = new(StructureType.MemoryFDPropertiesKhr);")]
        public static unsafe Result GetMemoryFdProperties(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<MemoryFdPropertiesKHR> pMemoryFdProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryFdProperties(device, handleType, fd, out pMemoryFdProperties.GetPinnableReference());
        }

    }
}

