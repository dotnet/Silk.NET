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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrExternalMemoryFdOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] MemoryGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, pGetFdInfo, out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<MemoryGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, in pGetFdInfo.GetPinnableReference(), pFd);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryF(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<MemoryGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetMemoryF(device, in pGetFdInfo.GetPinnableReference(), out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryFdProperties(this KhrExternalMemoryFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] int fd, [Count(Count = 0), Flow(FlowDirection.Out)] Span<MemoryFdPropertiesKHR> pMemoryFdProperties)
        {
            // SpanOverloader
            return thisApi.GetMemoryFdProperties(device, handleType, fd, out pMemoryFdProperties.GetPinnableReference());
        }

    }
}

