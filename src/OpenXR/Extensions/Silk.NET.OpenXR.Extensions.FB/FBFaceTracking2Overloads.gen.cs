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
    public static class FBFaceTracking2Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfo2FB* createInfo, [Count(Count = 0)] Span<FaceTracker2FB> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker2fB(session, createInfo, ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfo2FB> createInfo, [Count(Count = 0)] FaceTracker2FB* faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker2fB(session, in createInfo.GetPinnableReference(), faceTracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTracker2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfo2FB> createInfo, [Count(Count = 0)] Span<FaceTracker2FB> faceTracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTracker2fB(session, in createInfo.GetPinnableReference(), ref faceTracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeights2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceExpressionInfo2FB* expressionInfo, [Count(Count = 0)] Span<FaceExpressionWeights2FB> expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeights2fB(faceTracker, expressionInfo, ref expressionWeights.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeights2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceExpressionInfo2FB> expressionInfo, [Count(Count = 0)] FaceExpressionWeights2FB* expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeights2fB(faceTracker, in expressionInfo.GetPinnableReference(), expressionWeights);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFaceExpressionWeights2fB(this FBFaceTracking2 thisApi, [Count(Count = 0)] FaceTracker2FB faceTracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceExpressionInfo2FB> expressionInfo, [Count(Count = 0)] Span<FaceExpressionWeights2FB> expressionWeights)
        {
            // SpanOverloader
            return thisApi.GetFaceExpressionWeights2fB(faceTracker, in expressionInfo.GetPinnableReference(), ref expressionWeights.GetPinnableReference());
        }

    }
}

