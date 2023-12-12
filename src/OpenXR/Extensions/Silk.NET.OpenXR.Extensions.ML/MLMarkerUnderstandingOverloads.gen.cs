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
    public static class MLMarkerUnderstandingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerDetectorML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerDetectorCreateInfoML* createInfo, [Count(Count = 0)] Span<MarkerDetectorML> markerDetector)
        {
            // SpanOverloader
            return thisApi.CreateMarkerDetectorML(session, createInfo, ref markerDetector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerDetectorML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerDetectorCreateInfoML> createInfo, [Count(Count = 0)] MarkerDetectorML* markerDetector)
        {
            // SpanOverloader
            return thisApi.CreateMarkerDetectorML(session, in createInfo.GetPinnableReference(), markerDetector);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerDetectorML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerDetectorCreateInfoML> createInfo, [Count(Count = 0)] Span<MarkerDetectorML> markerDetector)
        {
            // SpanOverloader
            return thisApi.CreateMarkerDetectorML(session, in createInfo.GetPinnableReference(), ref markerDetector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MarkerSpaceCreateInfoML* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceML(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerSpaceCreateInfoML> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceML(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateMarkerSpaceML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MarkerSpaceCreateInfoML> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateMarkerSpaceML(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerDetectorStateML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] Span<MarkerDetectorStateML> state)
        {
            // SpanOverloader
            return thisApi.GetMarkerDetectorStateML(markerDetector, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerLengthML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] Span<float> meters)
        {
            // SpanOverloader
            return thisApi.GetMarkerLengthML(markerDetector, marker, ref meters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerNumberML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] Span<ulong> number)
        {
            // SpanOverloader
            return thisApi.GetMarkerNumberML(markerDetector, marker, ref number.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerReprojectionErrorML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] Span<float> reprojectionErrorMeters)
        {
            // SpanOverloader
            return thisApi.GetMarkerReprojectionErrorML(markerDetector, marker, ref reprojectionErrorMeters.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkersML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] uint* markerCountOutput, [Count(Parameter = "markerCapacityInput")] Span<ulong> markers)
        {
            // SpanOverloader
            return thisApi.GetMarkersML(markerDetector, markerCapacityInput, markerCountOutput, ref markers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkersML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] Span<uint> markerCountOutput, [Count(Parameter = "markerCapacityInput")] ulong* markers)
        {
            // SpanOverloader
            return thisApi.GetMarkersML(markerDetector, markerCapacityInput, ref markerCountOutput.GetPinnableReference(), markers);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkersML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] uint markerCapacityInput, [Count(Count = 0)] Span<uint> markerCountOutput, [Count(Parameter = "markerCapacityInput")] Span<ulong> markers)
        {
            // SpanOverloader
            return thisApi.GetMarkersML(markerDetector, markerCapacityInput, ref markerCountOutput.GetPinnableReference(), ref markers.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerStringML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetMarkerStringML(markerDetector, marker, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerStringML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetMarkerStringML(markerDetector, marker, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerStringML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetMarkerStringML(markerDetector, marker, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetMarkerStringML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] ulong marker, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetMarkerStringML(markerDetector, marker, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result SnapshotMarkerDetectorML(this MLMarkerUnderstanding thisApi, [Count(Count = 0)] MarkerDetectorML markerDetector, [Count(Count = 0)] Span<MarkerDetectorSnapshotInfoML> snapshotInfo)
        {
            // SpanOverloader
            return thisApi.SnapshotMarkerDetectorML(markerDetector, ref snapshotInfo.GetPinnableReference());
        }

    }
}

