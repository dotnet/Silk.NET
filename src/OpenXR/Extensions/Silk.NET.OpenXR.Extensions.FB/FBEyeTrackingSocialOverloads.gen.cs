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

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBEyeTrackingSocialOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEyeTrackerFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeTrackerCreateInfoFB* createInfo, [Count(Count = 0)] Span<EyeTrackerFB> eyeTracker)
        {
            // SpanOverloader
            return thisApi.CreateEyeTrackerFB(session, createInfo, ref eyeTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEyeTrackerFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EyeTrackerCreateInfoFB> createInfo, [Count(Count = 0)] EyeTrackerFB* eyeTracker)
        {
            // SpanOverloader
            return thisApi.CreateEyeTrackerFB(session, in createInfo.GetPinnableReference(), eyeTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateEyeTrackerFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EyeTrackerCreateInfoFB> createInfo, [Count(Count = 0)] Span<EyeTrackerFB> eyeTracker)
        {
            // SpanOverloader
            return thisApi.CreateEyeTrackerFB(session, in createInfo.GetPinnableReference(), ref eyeTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEyeGazesFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] EyeGazesInfoFB* gazeInfo, [Count(Count = 0)] Span<EyeGazesFB> eyeGazes)
        {
            // SpanOverloader
            return thisApi.GetEyeGazesFB(eyeTracker, gazeInfo, ref eyeGazes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEyeGazesFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EyeGazesInfoFB> gazeInfo, [Count(Count = 0)] EyeGazesFB* eyeGazes)
        {
            // SpanOverloader
            return thisApi.GetEyeGazesFB(eyeTracker, in gazeInfo.GetPinnableReference(), eyeGazes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetEyeGazesFB(this FBEyeTrackingSocial thisApi, [Count(Count = 0)] EyeTrackerFB eyeTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EyeGazesInfoFB> gazeInfo, [Count(Count = 0)] Span<EyeGazesFB> eyeGazes)
        {
            // SpanOverloader
            return thisApi.GetEyeGazesFB(eyeTracker, in gazeInfo.GetPinnableReference(), ref eyeGazes.GetPinnableReference());
        }

    }
}

