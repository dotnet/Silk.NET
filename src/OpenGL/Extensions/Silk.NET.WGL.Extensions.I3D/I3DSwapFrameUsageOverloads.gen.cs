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

namespace Silk.NET.WGL.Extensions.I3D
{
    public static class I3DSwapFrameUsageOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetFrameUsageI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pUsage)
        {
            // SpanOverloader
            return thisApi.GetFrameUsageI3D(out pUsage.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(pFrameCount, pMissedFrames, out pLastMissedUsage.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(pFrameCount, out pMissedFrames.GetPinnableReference(), pLastMissedUsage);
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(pFrameCount, out pMissedFrames.GetPinnableReference(), out pLastMissedUsage.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(out pFrameCount.GetPinnableReference(), pMissedFrames, pLastMissedUsage);
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(out pFrameCount.GetPinnableReference(), pMissedFrames, out pLastMissedUsage.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(out pFrameCount.GetPinnableReference(), out pMissedFrames.GetPinnableReference(), pLastMissedUsage);
        }

        public static unsafe Silk.NET.Core.Bool32 QueryFrameTrackingI3D(this I3DSwapFrameUsage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pLastMissedUsage)
        {
            // SpanOverloader
            return thisApi.QueryFrameTrackingI3D(out pFrameCount.GetPinnableReference(), out pMissedFrames.GetPinnableReference(), out pLastMissedUsage.GetPinnableReference());
        }

    }
}

