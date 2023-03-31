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
    public static class FBSceneCaptureOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result RequestSceneCaptureFB(this FBSceneCapture thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SceneCaptureRequestInfoFB* info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.RequestSceneCaptureFB(session, info, ref requestId.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestSceneCaptureFB(this FBSceneCapture thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCaptureRequestInfoFB> info, [Count(Count = 0)] ulong* requestId)
        {
            // SpanOverloader
            return thisApi.RequestSceneCaptureFB(session, in info.GetPinnableReference(), requestId);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestSceneCaptureFB(this FBSceneCapture thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SceneCaptureRequestInfoFB> info, [Count(Count = 0)] Span<ulong> requestId)
        {
            // SpanOverloader
            return thisApi.RequestSceneCaptureFB(session, in info.GetPinnableReference(), ref requestId.GetPinnableReference());
        }

    }
}

