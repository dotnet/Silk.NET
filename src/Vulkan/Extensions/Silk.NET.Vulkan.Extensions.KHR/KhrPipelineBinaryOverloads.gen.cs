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
    public static class KhrPipelineBinaryOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryHandlesInfoKHR> pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, pCreateInfo, pAllocator, out pBinaries.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, pCreateInfo, in pAllocator.GetPinnableReference(), pBinaries);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryCreateInfoKHR* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryHandlesInfoKHR> pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, pCreateInfo, in pAllocator.GetPinnableReference(), out pBinaries.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, in pCreateInfo.GetPinnableReference(), pAllocator, pBinaries);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryHandlesInfoKHR> pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, in pCreateInfo.GetPinnableReference(), pAllocator, out pBinaries.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryHandlesInfoKHR* pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), pBinaries);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pBinaries = new(StructureType.PipelineBinaryHandlesInfoKhr);")]
        public static unsafe Result CreatePipelineBinaries(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryCreateInfoKHR> pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryHandlesInfoKHR> pBinaries)
        {
            // SpanOverloader
            return thisApi.CreatePipelineBinaries(device, in pCreateInfo.GetPinnableReference(), in pAllocator.GetPinnableReference(), out pBinaries.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void DestroyPipelineBinary(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PipelineBinaryKHR pipelineBinary, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            thisApi.DestroyPipelineBinary(device, pipelineBinary, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, pPipelineBinaryKey, pPipelineBinaryDataSize, ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, pPipelineBinaryKey, ref pPipelineBinaryDataSize.GetPinnableReference(), pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, pPipelineBinaryKey, ref pPipelineBinaryDataSize.GetPinnableReference(), ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, ref pPipelineBinaryKey.GetPinnableReference(), pPipelineBinaryDataSize, pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, ref pPipelineBinaryKey.GetPinnableReference(), pPipelineBinaryDataSize, ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, ref pPipelineBinaryKey.GetPinnableReference(), ref pPipelineBinaryDataSize.GetPinnableReference(), pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineBinaryDataInfoKHR* pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, pInfo, ref pPipelineBinaryKey.GetPinnableReference(), ref pPipelineBinaryDataSize.GetPinnableReference(), ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), pPipelineBinaryKey, pPipelineBinaryDataSize, pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), pPipelineBinaryKey, pPipelineBinaryDataSize, ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), pPipelineBinaryKey, ref pPipelineBinaryDataSize.GetPinnableReference(), pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] PipelineBinaryKeyKHR* pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), pPipelineBinaryKey, ref pPipelineBinaryDataSize.GetPinnableReference(), ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), ref pPipelineBinaryKey.GetPinnableReference(), pPipelineBinaryDataSize, pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] nuint* pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), ref pPipelineBinaryKey.GetPinnableReference(), pPipelineBinaryDataSize, ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] void* pPipelineBinaryData)
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), ref pPipelineBinaryKey.GetPinnableReference(), ref pPipelineBinaryDataSize.GetPinnableReference(), pPipelineBinaryData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineBinaryData<T0>(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineBinaryDataInfoKHR> pInfo, [Count(Count = 0)] Span<PipelineBinaryKeyKHR> pPipelineBinaryKey, [Count(Count = 0)] Span<nuint> pPipelineBinaryDataSize, [Count(Parameter = "pPipelineBinaryDataSize")] Span<T0> pPipelineBinaryData) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetPipelineBinaryData(device, in pInfo.GetPinnableReference(), ref pPipelineBinaryKey.GetPinnableReference(), ref pPipelineBinaryDataSize.GetPinnableReference(), ref pPipelineBinaryData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPipelineKey = new(StructureType.PipelineBinaryKeyKhr);")]
        public static unsafe Result GetPipelineKey(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineCreateInfoKHR* pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryKeyKHR> pPipelineKey)
        {
            // SpanOverloader
            return thisApi.GetPipelineKey(device, pPipelineCreateInfo, out pPipelineKey.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPipelineKey(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCreateInfoKHR> pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PipelineBinaryKeyKHR* pPipelineKey)
        {
            // SpanOverloader
            return thisApi.GetPipelineKey(device, in pPipelineCreateInfo.GetPinnableReference(), pPipelineKey);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pPipelineKey = new(StructureType.PipelineBinaryKeyKhr);")]
        public static unsafe Result GetPipelineKey(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PipelineCreateInfoKHR> pPipelineCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PipelineBinaryKeyKHR> pPipelineKey)
        {
            // SpanOverloader
            return thisApi.GetPipelineKey(device, in pPipelineCreateInfo.GetPinnableReference(), out pPipelineKey.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ReleaseCapturedPipelineData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReleaseCapturedPipelineDataInfoKHR* pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            return thisApi.ReleaseCapturedPipelineData(device, pInfo, in pAllocator.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ReleaseCapturedPipelineData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReleaseCapturedPipelineDataInfoKHR> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator)
        {
            // SpanOverloader
            return thisApi.ReleaseCapturedPipelineData(device, in pInfo.GetPinnableReference(), pAllocator);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ReleaseCapturedPipelineData(this KhrPipelineBinary thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ReleaseCapturedPipelineDataInfoKHR> pInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AllocationCallbacks> pAllocator)
        {
            // SpanOverloader
            return thisApi.ReleaseCapturedPipelineData(device, in pInfo.GetPinnableReference(), in pAllocator.GetPinnableReference());
        }

    }
}

