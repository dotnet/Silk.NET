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

namespace Silk.NET.OpenXR.Extensions.HTC
{
    public static class HtcFacialTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialTrackerHtc(this HtcFacialTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] Span<FacialTrackerHTC> facialTracker)
        {
            // SpanOverloader
            return thisApi.CreateFacialTrackerHtc(session, createInfo, ref facialTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialTrackerHtc(this HtcFacialTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialTrackerCreateInfoHTC> createInfo, [Count(Count = 0)] FacialTrackerHTC* facialTracker)
        {
            // SpanOverloader
            return thisApi.CreateFacialTrackerHtc(session, in createInfo.GetPinnableReference(), facialTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialTrackerHtc(this HtcFacialTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialTrackerCreateInfoHTC> createInfo, [Count(Count = 0)] Span<FacialTrackerHTC> facialTracker)
        {
            // SpanOverloader
            return thisApi.CreateFacialTrackerHtc(session, in createInfo.GetPinnableReference(), ref facialTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialExpressionsHtc(this HtcFacialTracking thisApi, [Count(Count = 0)] FacialTrackerHTC facialTracker, [Count(Count = 0)] Span<FacialExpressionsHTC> facialExpressions)
        {
            // SpanOverloader
            return thisApi.GetFacialExpressionsHtc(facialTracker, ref facialExpressions.GetPinnableReference());
        }

    }
}

