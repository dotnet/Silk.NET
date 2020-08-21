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
    public static class KhrPipelineExecutablePropertiesOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, pInternalRepresentationCount, out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, ref pInternalRepresentationCount.GetPinnableReference(), pInternalRepresentations);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, ref pInternalRepresentationCount.GetPinnableReference(), out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), pInternalRepresentationCount, pInternalRepresentations);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), pInternalRepresentationCount, out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), ref pInternalRepresentationCount.GetPinnableReference(), pInternalRepresentations);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Computed = "pInternalRepresentationCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), ref pInternalRepresentationCount.GetPinnableReference(), out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, pExecutableCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, ref pExecutableCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, ref pExecutableCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), pExecutableCount, pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), pExecutableCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pExecutableCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Computed = "pExecutableCount"), Flow(FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pExecutableCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, pStatisticCount, out pStatistics.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, ref pStatisticCount.GetPinnableReference(), pStatistics);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, ref pStatisticCount.GetPinnableReference(), out pStatistics.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), pStatisticCount, pStatistics);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), pStatisticCount, out pStatistics.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), ref pStatisticCount.GetPinnableReference(), pStatistics);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Computed = "pStatisticCount"), Flow(FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), ref pStatisticCount.GetPinnableReference(), out pStatistics.GetPinnableReference());
        }

    }
}

