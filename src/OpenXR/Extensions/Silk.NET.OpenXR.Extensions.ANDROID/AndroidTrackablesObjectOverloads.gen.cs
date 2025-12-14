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
    public static class AndroidTrackablesObjectOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableObject(this AndroidTrackablesObject thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] Span<TrackableObjectANDROID> objectOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableObject(tracker, getInfo, ref objectOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableObject(this AndroidTrackablesObject thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] TrackableObjectANDROID* objectOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableObject(tracker, in getInfo.GetPinnableReference(), objectOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackableObject(this AndroidTrackablesObject thisApi, [Count(Count = 0)] TrackableTrackerANDROID tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] Span<TrackableObjectANDROID> objectOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackableObject(tracker, in getInfo.GetPinnableReference(), ref objectOutput.GetPinnableReference());
        }

    }
}

