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
    public static class AndroidTrackablesOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpace(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AnchorSpaceCreateInfoANDROID* createInfo, [Count(Count = 0)] Span<Space> anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpace(session, createInfo, ref anchorOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpace(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSpaceCreateInfoANDROID> createInfo, [Count(Count = 0)] Space* anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpace(session, in createInfo.GetPinnableReference(), anchorOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateAnchorSpace(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AnchorSpaceCreateInfoANDROID> createInfo, [Count(Count = 0)] Span<Space> anchorOutput)
        {
            // SpanOverloader
            return thisApi.CreateAnchorSpace(session, in createInfo.GetPinnableReference(), ref anchorOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTrackableTracker(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] Span<TrackableTrackerANDROID> trackableTracker)
        {
            // SpanOverloader
            return thisApi.CreateTrackableTracker(session, createInfo, ref trackableTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTrackableTracker(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableTrackerCreateInfoANDROID> createInfo, [Count(Count = 0)] TrackableTrackerANDROID* trackableTracker)
        {
            // SpanOverloader
            return thisApi.CreateTrackableTracker(session, in createInfo.GetPinnableReference(), trackableTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateTrackableTracker(this AndroidTrackables thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableTrackerCreateInfoANDROID> createInfo, [Count(Count = 0)] Span<TrackableTrackerANDROID> trackableTracker)
        {
            // SpanOverloader
            return thisApi.CreateTrackableTracker(session, in createInfo.GetPinnableReference(), ref trackableTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedAnchorTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedAnchorTrackableTypes(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedAnchorTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedAnchorTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), trackableTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedAnchorTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedAnchorTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), trackableTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateSupportedTrackableTypes(this AndroidTrackables thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAllTrackables(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] uint* trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] Span<ulong> trackables)
        {
            // SpanOverloader
            return thisApi.GetAllTrackables(trackableTracker, trackableCapacityInput, trackableCountOutput, ref trackables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAllTrackables(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] Span<uint> trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] ulong* trackables)
        {
            // SpanOverloader
            return thisApi.GetAllTrackables(trackableTracker, trackableCapacityInput, ref trackableCountOutput.GetPinnableReference(), trackables);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetAllTrackables(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0)] uint trackableCapacityInput, [Count(Count = 0)] Span<uint> trackableCountOutput, [Count(Parameter = "trackableCapacityInput")] Span<ulong> trackables)
        {
            // SpanOverloader
            return thisApi.GetAllTrackables(trackableTracker, trackableCapacityInput, ref trackableCountOutput.GetPinnableReference(), ref trackables.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackablePlane(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] TrackableGetInfoANDROID* getInfo, [Count(Count = 0)] Span<TrackablePlaneANDROID> planeOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackablePlane(trackableTracker, getInfo, ref planeOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackablePlane(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] TrackablePlaneANDROID* planeOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackablePlane(trackableTracker, in getInfo.GetPinnableReference(), planeOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetTrackablePlane(this AndroidTrackables thisApi, [Count(Count = 0)] TrackableTrackerANDROID trackableTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TrackableGetInfoANDROID> getInfo, [Count(Count = 0)] Span<TrackablePlaneANDROID> planeOutput)
        {
            // SpanOverloader
            return thisApi.GetTrackablePlane(trackableTracker, in getInfo.GetPinnableReference(), ref planeOutput.GetPinnableReference());
        }

    }
}

