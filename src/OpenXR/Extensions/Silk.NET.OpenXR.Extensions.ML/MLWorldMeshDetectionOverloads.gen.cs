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

namespace Silk.NET.OpenXR.Extensions.ML
{
    public static class MLWorldMeshDetectionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateWorldMeshBufferML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferSizeML* size, [Count(Count = 0)] Span<WorldMeshBufferML> buffer)
        {
            // SpanOverloader
            return thisApi.AllocateWorldMeshBufferML(detector, size, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateWorldMeshBufferML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshBufferSizeML> size, [Count(Count = 0)] WorldMeshBufferML* buffer)
        {
            // SpanOverloader
            return thisApi.AllocateWorldMeshBufferML(detector, in size.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result AllocateWorldMeshBufferML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshBufferSizeML> size, [Count(Count = 0)] Span<WorldMeshBufferML> buffer)
        {
            // SpanOverloader
            return thisApi.AllocateWorldMeshBufferML(detector, in size.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateWorldMeshDetectorML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshDetectorCreateInfoML* createInfo, [Count(Count = 0)] Span<WorldMeshDetectorML> detector)
        {
            // SpanOverloader
            return thisApi.CreateWorldMeshDetectorML(session, createInfo, ref detector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateWorldMeshDetectorML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshDetectorCreateInfoML> createInfo, [Count(Count = 0)] WorldMeshDetectorML* detector)
        {
            // SpanOverloader
            return thisApi.CreateWorldMeshDetectorML(session, in createInfo.GetPinnableReference(), detector);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateWorldMeshDetectorML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshDetectorCreateInfoML> createInfo, [Count(Count = 0)] Span<WorldMeshDetectorML> detector)
        {
            // SpanOverloader
            return thisApi.CreateWorldMeshDetectorML(session, in createInfo.GetPinnableReference(), ref detector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result FreeWorldMeshBufferML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshBufferML> buffer)
        {
            // SpanOverloader
            return thisApi.FreeWorldMeshBufferML(detector, in buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetWorldMeshBufferRecommendSizeML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshBufferRecommendedSizeInfoML* sizeInfo, [Count(Count = 0)] Span<WorldMeshBufferSizeML> size)
        {
            // SpanOverloader
            return thisApi.GetWorldMeshBufferRecommendSizeML(detector, sizeInfo, ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetWorldMeshBufferRecommendSizeML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshBufferRecommendedSizeInfoML> sizeInfo, [Count(Count = 0)] WorldMeshBufferSizeML* size)
        {
            // SpanOverloader
            return thisApi.GetWorldMeshBufferRecommendSizeML(detector, in sizeInfo.GetPinnableReference(), size);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetWorldMeshBufferRecommendSizeML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshBufferRecommendedSizeInfoML> sizeInfo, [Count(Count = 0)] Span<WorldMeshBufferSizeML> size)
        {
            // SpanOverloader
            return thisApi.GetWorldMeshBufferRecommendSizeML(detector, in sizeInfo.GetPinnableReference(), ref size.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, getInfo, buffer, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] Span<WorldMeshBufferML> buffer, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, getInfo, ref buffer.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshGetInfoML* getInfo, [Count(Count = 0)] Span<WorldMeshBufferML> buffer, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, getInfo, ref buffer.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshGetInfoML> getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, in getInfo.GetPinnableReference(), buffer, future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshGetInfoML> getInfo, [Count(Count = 0)] WorldMeshBufferML* buffer, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, in getInfo.GetPinnableReference(), buffer, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshGetInfoML> getInfo, [Count(Count = 0)] Span<WorldMeshBufferML> buffer, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, in getInfo.GetPinnableReference(), ref buffer.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshGetInfoML> getInfo, [Count(Count = 0)] Span<WorldMeshBufferML> buffer, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshAsyncML(detector, in getInfo.GetPinnableReference(), ref buffer.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshCompleteML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshRequestCompletionInfoML* completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<WorldMeshRequestCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshCompleteML(detector, completionInfo, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshCompleteML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshRequestCompletionInfoML> completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] WorldMeshRequestCompletionML* completion)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshCompleteML(detector, in completionInfo.GetPinnableReference(), future, completion);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshCompleteML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshRequestCompletionInfoML> completionInfo, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<WorldMeshRequestCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshCompleteML(detector, in completionInfo.GetPinnableReference(), future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshStateAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] WorldMeshStateRequestInfoML* stateRequest, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshStateAsyncML(detector, stateRequest, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshStateAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshStateRequestInfoML> stateRequest, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshStateAsyncML(detector, in stateRequest.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshStateAsyncML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<WorldMeshStateRequestInfoML> stateRequest, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshStateAsyncML(detector, in stateRequest.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestWorldMeshStateCompleteML(this MLWorldMeshDetection thisApi, [Count(Count = 0)] WorldMeshDetectorML detector, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<WorldMeshStateRequestCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.RequestWorldMeshStateCompleteML(detector, future, ref completion.GetPinnableReference());
        }

    }
}

