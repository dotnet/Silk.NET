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
    public static class ExtPlaneDetectionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result BeginPlaneDetection(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PlaneDetectorBeginInfoEXT> beginInfo)
        {
            // SpanOverloader
            return thisApi.BeginPlaneDetection(planeDetector, in beginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePlaneDetector(this ExtPlaneDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorCreateInfoEXT* createInfo, [Count(Count = 0)] Span<PlaneDetectorEXT> planeDetector)
        {
            // SpanOverloader
            return thisApi.CreatePlaneDetector(session, createInfo, ref planeDetector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePlaneDetector(this ExtPlaneDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PlaneDetectorCreateInfoEXT> createInfo, [Count(Count = 0)] PlaneDetectorEXT* planeDetector)
        {
            // SpanOverloader
            return thisApi.CreatePlaneDetector(session, in createInfo.GetPinnableReference(), planeDetector);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePlaneDetector(this ExtPlaneDetection thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PlaneDetectorCreateInfoEXT> createInfo, [Count(Count = 0)] Span<PlaneDetectorEXT> planeDetector)
        {
            // SpanOverloader
            return thisApi.CreatePlaneDetector(session, in createInfo.GetPinnableReference(), ref planeDetector.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPlaneDetection(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PlaneDetectorGetInfoEXT* info, [Count(Count = 0)] Span<PlaneDetectorLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.GetPlaneDetection(planeDetector, info, ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPlaneDetection(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PlaneDetectorGetInfoEXT> info, [Count(Count = 0)] PlaneDetectorLocationsEXT* locations)
        {
            // SpanOverloader
            return thisApi.GetPlaneDetection(planeDetector, in info.GetPinnableReference(), locations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPlaneDetection(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PlaneDetectorGetInfoEXT> info, [Count(Count = 0)] Span<PlaneDetectorLocationsEXT> locations)
        {
            // SpanOverloader
            return thisApi.GetPlaneDetection(planeDetector, in info.GetPinnableReference(), ref locations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPlaneDetectionState(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] Span<PlaneDetectionStateEXT> state)
        {
            // SpanOverloader
            return thisApi.GetPlaneDetectionState(planeDetector, ref state.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPlanePolygonBuffer(this ExtPlaneDetection thisApi, [Count(Count = 0)] PlaneDetectorEXT planeDetector, [Count(Count = 0)] ulong planeId, [Count(Count = 0)] uint polygonBufferIndex, [Count(Count = 0)] Span<PlaneDetectorPolygonBufferEXT> polygonBuffer)
        {
            // SpanOverloader
            return thisApi.GetPlanePolygonBuffer(planeDetector, planeId, polygonBufferIndex, ref polygonBuffer.GetPinnableReference());
        }

    }
}

