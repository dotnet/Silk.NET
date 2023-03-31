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
    public static class I3DGenlockOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetGenlockSampleRateI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uRate)
        {
            // SpanOverloader
            return thisApi.GetGenlockSampleRateI3D(hDC, out uRate.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGenlockSourceDelayI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uDelay)
        {
            // SpanOverloader
            return thisApi.GetGenlockSourceDelayI3D(hDC, out uDelay.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGenlockSourceEdgeI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uEdge)
        {
            // SpanOverloader
            return thisApi.GetGenlockSourceEdgeI3D(hDC, out uEdge.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGenlockSourceI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uSource)
        {
            // SpanOverloader
            return thisApi.GetGenlockSourceI3D(hDC, out uSource.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 IsEnabledGenlockI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<Silk.NET.Core.Bool32> pFlag)
        {
            // SpanOverloader
            return thisApi.IsEnabledGenlockI3D(hDC, out pFlag.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uMaxPixelDelay)
        {
            // SpanOverloader
            return thisApi.QueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay, out uMaxPixelDelay.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxPixelDelay)
        {
            // SpanOverloader
            return thisApi.QueryGenlockMaxSourceDelayI3D(hDC, out uMaxLineDelay.GetPinnableReference(), uMaxPixelDelay);
        }

        public static unsafe Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D(this I3DGenlock thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> uMaxPixelDelay)
        {
            // SpanOverloader
            return thisApi.QueryGenlockMaxSourceDelayI3D(hDC, out uMaxLineDelay.GetPinnableReference(), out uMaxPixelDelay.GetPinnableReference());
        }

    }
}

