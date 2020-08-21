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
    public static class KhrExternalFenceWin32Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] FenceGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<IntPtr> pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, pGetWin32HandleInfo, out pHandle.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<FenceGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] IntPtr* pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<FenceGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<IntPtr> pHandle)
        {
            // SpanOverloader
            return thisApi.GetFenceWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), out pHandle.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result ImportFenceWin32Handle(this KhrExternalFenceWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImportFenceWin32HandleInfoKHR> pImportFenceWin32HandleInfo)
        {
            // SpanOverloader
            return thisApi.ImportFenceWin32Handle(device, in pImportFenceWin32HandleInfo.GetPinnableReference());
        }

    }
}

