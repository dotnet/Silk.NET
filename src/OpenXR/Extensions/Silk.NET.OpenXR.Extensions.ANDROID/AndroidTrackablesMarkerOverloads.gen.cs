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

namespace Silk.NET.OpenXR.Extensions.ANDROID
{
    public static class AndroidTrackablesMarkerOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableMarker(this AndroidTrackablesMarker thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] Span<TrackableMarkerANDROID> markerOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableMarker(tracker, getInfo, ref markerOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableMarker(this AndroidTrackablesMarker thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] TrackableMarkerANDROID* markerOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableMarker(tracker, in getInfo.GetPinnableReference(), markerOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableMarker(this AndroidTrackablesMarker thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] Span<TrackableMarkerANDROID> markerOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableMarker(tracker, in getInfo.GetPinnableReference(), ref markerOutput.GetPinnableReference());
        }

    }
}

