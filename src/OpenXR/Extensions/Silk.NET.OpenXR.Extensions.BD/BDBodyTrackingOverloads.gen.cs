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

namespace Silk.NET.OpenXR.Extensions.BD
{
    public static class BDBodyTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerBD(this BDBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyTrackerCreateInfoBD* createInfo, [Count(Count = 0)] Span<BodyTrackerBD> bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerBD(session, createInfo, ref bodyTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerBD(this BDBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyTrackerCreateInfoBD> createInfo, [Count(Count = 0)] BodyTrackerBD* bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerBD(session, in createInfo.GetPinnableReference(), bodyTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateBodyTrackerBD(this BDBodyTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyTrackerCreateInfoBD> createInfo, [Count(Count = 0)] Span<BodyTrackerBD> bodyTracker)
        {
            // SpanOverloader
            return thisApi.CreateBodyTrackerBD(session, in createInfo.GetPinnableReference(), ref bodyTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsBD(this BDBodyTracking thisApi, [Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BodyJointsLocateInfoBD* locateInfo, [Count(Count = 0)] Span<BodyJointLocationsBD> locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsBD(bodyTracker, locateInfo, ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsBD(this BDBodyTracking thisApi, [Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyJointsLocateInfoBD> locateInfo, [Count(Count = 0)] BodyJointLocationsBD* locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsBD(bodyTracker, in locateInfo.GetPinnableReference(), locations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateBodyJointsBD(this BDBodyTracking thisApi, [Count(Count = 0)] BodyTrackerBD bodyTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<BodyJointsLocateInfoBD> locateInfo, [Count(Count = 0)] Span<BodyJointLocationsBD> locations)
        {
            // SpanOverloader
            return thisApi.LocateBodyJointsBD(bodyTracker, in locateInfo.GetPinnableReference(), ref locations.GetPinnableReference());
        }

    }
}

