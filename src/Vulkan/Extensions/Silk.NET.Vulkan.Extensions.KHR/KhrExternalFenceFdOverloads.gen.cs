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
    public static class KhrExternalFenceFdOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceF(this KhrExternalFenceFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetFenceF(device, pGetFdInfo, out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceF(this KhrExternalFenceFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* pFd)
        {
            // SpanOverloader
            return thisApi.GetFenceF(device, in pGetFdInfo.GetPinnableReference(), pFd);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFenceF(this KhrExternalFenceFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FenceGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetFenceF(device, in pGetFdInfo.GetPinnableReference(), out pFd.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportFenceF(this KhrExternalFenceFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ImportFenceFdInfoKHR> pImportFenceFdInfo)
        {
            // SpanOverloader
            return thisApi.ImportFenceF(device, in pImportFenceFdInfo.GetPinnableReference());
        }

    }
}

