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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtHandTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] Span<HandTrackerEXT> handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, createInfo, ref handTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HandTrackerCreateInfoEXT> createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, in createInfo.GetPinnableReference(), handTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HandTrackerCreateInfoEXT> createInfo, [Count(Count = 0)] Span<HandTrackerEXT> handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, in createInfo.GetPinnableReference(), ref handTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] Span<HandJointLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, locateInfo, ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HandJointsLocateInfoEXT> locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, in locateInfo.GetPinnableReference(), locations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<HandJointsLocateInfoEXT> locateInfo, [Count(Count = 0)] Span<HandJointLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, in locateInfo.GetPinnableReference(), ref locations.GetPinnableReference());
        }

    }
}

