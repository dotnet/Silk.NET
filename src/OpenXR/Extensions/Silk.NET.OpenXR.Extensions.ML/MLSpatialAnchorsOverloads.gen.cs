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
    public static class MLSpatialAnchorsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsAsyncML(this MLSpatialAnchors thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorsCreateInfoBaseHeaderML* createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsAsyncML(session, createInfo, ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsAsyncML(this MLSpatialAnchors thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsCreateInfoBaseHeaderML> createInfo, [Count(Count = 0)] FutureEXT* future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsAsyncML(session, in createInfo.GetPinnableReference(), future);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsAsyncML(this MLSpatialAnchors thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorsCreateInfoBaseHeaderML> createInfo, [Count(Count = 0)] Span<FutureEXT> future)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsAsyncML(session, in createInfo.GetPinnableReference(), ref future.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorsCompleteML(this MLSpatialAnchors thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] FutureEXT future, [Count(Count = 0)] Span<CreateSpatialAnchorsCompletionML> completion)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorsCompleteML(session, future, ref completion.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialAnchorStateML(this MLSpatialAnchors thisApi, [Count(Count = 0)] Space anchor, [Count(Count = 0)] Span<SpatialAnchorStateML> state)
        {
            // SpanOverloader
            return thisApi.GetSpatialAnchorStateML(anchor, ref state.GetPinnableReference());
        }

    }
}

