// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrExternalSemaphoreFdOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetSemaphoreF(this KhrExternalSemaphoreFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetFdInfoKHR* pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreF(device, pGetFdInfo, out pFd.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetSemaphoreF(this KhrExternalSemaphoreFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] int* pFd)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreF(device, in pGetFdInfo.GetPinnableReference(), pFd);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetSemaphoreF(this KhrExternalSemaphoreFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreGetFdInfoKHR> pGetFdInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<int> pFd)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreF(device, in pGetFdInfo.GetPinnableReference(), out pFd.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ImportSemaphoreF(this KhrExternalSemaphoreFd thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImportSemaphoreFdInfoKHR> pImportSemaphoreFdInfo)
        {
            // SpanOverloader
            return thisApi.ImportSemaphoreF(device, in pImportSemaphoreFdInfo.GetPinnableReference());
        }

    }
}

