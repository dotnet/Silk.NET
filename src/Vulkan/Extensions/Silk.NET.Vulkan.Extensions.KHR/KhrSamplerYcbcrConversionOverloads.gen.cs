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
    public static class KhrSamplerYcbcrConversionOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, pAllocator, out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, in pAllocator.GetPinnableReference(), pYcbcrConversion);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SamplerYcbcrConversionCreateInfo* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), pAllocator, pYcbcrConversion);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] SamplerYcbcrConversion* pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pYcbcrConversion);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateSamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SamplerYcbcrConversionCreateInfo> pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] Span<SamplerYcbcrConversion> pYcbcrConversion)
        {
            // SpanOverloader
            return thisApi.CreateSamplerYcbcrConversion(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pYcbcrConversion.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe void DestroySamplerYcbcrConversion(this KhrSamplerYcbcrConversion thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] SamplerYcbcrConversion ycbcrConversion, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroySamplerYcbcrConversion(device, ycbcrConversion, in pAllocator.GetPinnableReference());
        }

    }
}

