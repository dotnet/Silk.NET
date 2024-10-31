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
    public static class HtcBodyTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoHTC* createInfo, [Count(Count = 0)] Span<BodyTrackerHTC> bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerHtc(session, createInfo, ref bodyTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyTrackerCreateInfoHTC> createInfo, [Count(Count = 0)] BodyTrackerHTC* bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerHtc(session, in createInfo.GetPinnableReference(), bodyTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyTrackerCreateInfoHTC> createInfo, [Count(Count = 0)] Span<BodyTrackerHTC> bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerHtc(session, in createInfo.GetPinnableReference(), ref bodyTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetBodySkeletonHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0)] Space baseSpace, [Count(Count = 0)] uint skeletonGenerationId, [Count(Count = 0)] Span<BodySkeletonHTC> skeleton)
        {
            // SpanOverloader
            return thisApi.GetBodySkeletonHtc(bodyTracker, baseSpace, skeletonGenerationId, ref skeleton.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoHTC* locateInfo, [Count(Count = 0)] Span<BodyJointLocationsHTC> locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsHtc(bodyTracker, locateInfo, ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyJointsLocateInfoHTC> locateInfo, [Count(Count = 0)] BodyJointLocationsHTC* locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsHtc(bodyTracker, in locateInfo.GetPinnableReference(), locations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsHtc(this HtcBodyTracking thisApi, [Count(Count = 0)] BodyTrackerHTC bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyJointsLocateInfoHTC> locateInfo, [Count(Count = 0)] Span<BodyJointLocationsHTC> locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsHtc(bodyTracker, in locateInfo.GetPinnableReference(), ref locations.GetPinnableReference());
        }

    }
}

