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
    public static class KhrPipelineExecutablePropertiesOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, pInternalRepresentationCount, out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, ref pInternalRepresentationCount.GetPinnableReference(), pInternalRepresentations);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, pExecutableInfo, ref pInternalRepresentationCount.GetPinnableReference(), out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), pInternalRepresentationCount, pInternalRepresentations);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), pInternalRepresentationCount, out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableInternalRepresentationKHR* pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), ref pInternalRepresentationCount.GetPinnableReference(), pInternalRepresentations);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pInternalRepresentations = new(StructureType.PipelineExecutableInternalRepresentationKhr);")]
        public static unsafe Result GetPipelineExecutableInternalRepresentation(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pInternalRepresentationCount, [Count(Parameter = "pInternalRepresentationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableInternalRepresentationKHR> pInternalRepresentations)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableInternalRepresentation(device, in pExecutableInfo.GetPinnableReference(), ref pInternalRepresentationCount.GetPinnableReference(), out pInternalRepresentations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, pExecutableCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, ref pExecutableCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineInfoKHR* pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, pPipelineInfo, ref pExecutableCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), pExecutableCount, pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] uint* pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), pExecutableCount, out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutablePropertiesKHR* pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pExecutableCount.GetPinnableReference(), pProperties);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.PipelineExecutablePropertiesKhr);")]
        public static unsafe Result GetPipelineExecutableProperties(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineInfoKHR> pPipelineInfo, [Count(Count = 0)] Span<uint> pExecutableCount, [Count(Parameter = "pExecutableCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutablePropertiesKHR> pProperties)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableProperties(device, in pPipelineInfo.GetPinnableReference(), ref pExecutableCount.GetPinnableReference(), out pProperties.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, pStatisticCount, out pStatistics.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, ref pStatisticCount.GetPinnableReference(), pStatistics);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineExecutableInfoKHR* pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, pExecutableInfo, ref pStatisticCount.GetPinnableReference(), out pStatistics.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), pStatisticCount, pStatistics);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] uint* pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), pStatisticCount, out pStatistics.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineExecutableStatisticKHR* pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), ref pStatisticCount.GetPinnableReference(), pStatistics);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pStatistics = new(StructureType.PipelineExecutableStatisticKhr);")]
        public static unsafe Result GetPipelineExecutableStatistic(this KhrPipelineExecutableProperties thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineExecutableInfoKHR> pExecutableInfo, [Count(Count = 0)] Span<uint> pStatisticCount, [Count(Parameter = "pStatisticCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineExecutableStatisticKHR> pStatistics)
        {
            // SpanOverloader
            return thisApi.GetPipelineExecutableStatistic(device, in pExecutableInfo.GetPinnableReference(), ref pStatisticCount.GetPinnableReference(), out pStatistics.GetPinnableReference());
        }

    }
}

