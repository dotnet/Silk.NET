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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtHandTrackingOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] HandTrackerCreateInfoEXT* createInfo, [Count(Count = 0)] Span<HandTrackerEXT> handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, createInfo, ref handTracker.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandTrackerCreateInfoEXT> createInfo, [Count(Count = 0)] HandTrackerEXT* handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, in createInfo.GetPinnableReference(), handTracker);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CreateHandTracker(this ExtHandTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandTrackerCreateInfoEXT> createInfo, [Count(Count = 0)] Span<HandTrackerEXT> handTracker)
        {
            // SpanOverloader
            return thisApi.CreateHandTracker(session, in createInfo.GetPinnableReference(), ref handTracker.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] HandJointsLocateInfoEXT* locateInfo, [Count(Count = 0)] Span<HandJointLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, locateInfo, ref locations.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandJointsLocateInfoEXT> locateInfo, [Count(Count = 0)] HandJointLocationsEXT* locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, in locateInfo.GetPinnableReference(), locations);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result LocateHandJoints(this ExtHandTracking thisApi, [Count(Count = 0)] HandTrackerEXT handTracker, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<HandJointsLocateInfoEXT> locateInfo, [Count(Count = 0)] Span<HandJointLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.LocateHandJoints(handTracker, in locateInfo.GetPinnableReference(), ref locations.GetPinnableReference());
        }

    }
}

