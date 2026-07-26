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
    public static class AndroidFaceTrackingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker(this AndroidFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoANDROID* createInfo, [Count(Count = 0)] Span<FaceTrackerANDROID> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker(session, createInfo, ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker(this AndroidFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoANDROID> createInfo, [Count(Count = 0)] FaceTrackerANDROID* faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker(session, in createInfo.GetPinnableReference(), faceTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker(this AndroidFaceTracking thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoANDROID> createInfo, [Count(Count = 0)] Span<FaceTrackerANDROID> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker(session, in createInfo.GetPinnableReference(), ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceCalibrationState(this AndroidFaceTracking thisApi, [Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0)] Span<uint> faceIsCalibratedOutput)
        {
            // SpanOverloader
            return thisApi.GetFaceCalibrationState(faceTracker, ref faceIsCalibratedOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceState(this AndroidFaceTracking thisApi, [Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceStateGetInfoANDROID* getInfo, [Count(Count = 0)] Span<FaceStateANDROID> faceStateOutput)
        {
            // SpanOverloader
            return thisApi.GetFaceState(faceTracker, getInfo, ref faceStateOutput.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceState(this AndroidFaceTracking thisApi, [Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceStateGetInfoANDROID> getInfo, [Count(Count = 0)] FaceStateANDROID* faceStateOutput)
        {
            // SpanOverloader
            return thisApi.GetFaceState(faceTracker, in getInfo.GetPinnableReference(), faceStateOutput);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceState(this AndroidFaceTracking thisApi, [Count(Count = 0)] FaceTrackerANDROID faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceStateGetInfoANDROID> getInfo, [Count(Count = 0)] Span<FaceStateANDROID> faceStateOutput)
        {
            // SpanOverloader
            return thisApi.GetFaceState(faceTracker, in getInfo.GetPinnableReference(), ref faceStateOutput.GetPinnableReference());
        }

    }
}

