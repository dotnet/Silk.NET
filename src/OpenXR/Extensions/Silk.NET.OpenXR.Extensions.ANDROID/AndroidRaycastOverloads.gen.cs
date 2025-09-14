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
    public static class AndroidRaycastOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRaycastSupportedTrackableTypes(this AndroidRaycast thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] uint* trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateRaycastSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, trackableTypeCountOutput, ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRaycastSupportedTrackableTypes(this AndroidRaycast thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] TrackableTypeANDROID* trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateRaycastSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), trackableTypes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateRaycastSupportedTrackableTypes(this AndroidRaycast thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint trackableTypeCapacityInput, [Count(Count = 0)] Span<uint> trackableTypeCountOutput, [Count(Parameter = "trackableTypeCapacityInput")] Span<TrackableTypeANDROID> trackableTypes)
        {
            // SpanOverloader
            return thisApi.EnumerateRaycastSupportedTrackableTypes(instance, systemId, trackableTypeCapacityInput, ref trackableTypeCountOutput.GetPinnableReference(), ref trackableTypes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result Raycast(this AndroidRaycast thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] RaycastInfoANDROID* rayInfo, [Count(Count = 0)] Span<RaycastHitResultsANDROID> results)
        {
            // SpanOverloader
            return thisApi.Raycast(session, rayInfo, ref results.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result Raycast(this AndroidRaycast thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RaycastInfoANDROID> rayInfo, [Count(Count = 0)] RaycastHitResultsANDROID* results)
        {
            // SpanOverloader
            return thisApi.Raycast(session, in rayInfo.GetPinnableReference(), results);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result Raycast(this AndroidRaycast thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<RaycastInfoANDROID> rayInfo, [Count(Count = 0)] Span<RaycastHitResultsANDROID> results)
        {
            // SpanOverloader
            return thisApi.Raycast(session, in rayInfo.GetPinnableReference(), ref results.GetPinnableReference());
        }

    }
}

