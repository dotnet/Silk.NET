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

namespace Silk.NET.WGL.Extensions.NV
{
    public static class NVSwapGroupOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 QueryFrameCount(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count)
        {
            // SpanOverloader
            return thisApi.QueryFrameCount(hDC, out count.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryMaxSwapGroups(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* maxGroups, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> maxBarriers)
        {
            // SpanOverloader
            return thisApi.QueryMaxSwapGroups(hDC, maxGroups, out maxBarriers.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryMaxSwapGroups(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> maxGroups, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* maxBarriers)
        {
            // SpanOverloader
            return thisApi.QueryMaxSwapGroups(hDC, out maxGroups.GetPinnableReference(), maxBarriers);
        }

        public static unsafe Silk.NET.Core.Bool32 QueryMaxSwapGroups(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> maxGroups, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> maxBarriers)
        {
            // SpanOverloader
            return thisApi.QueryMaxSwapGroups(hDC, out maxGroups.GetPinnableReference(), out maxBarriers.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QuerySwapGroup(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* group, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> barrier)
        {
            // SpanOverloader
            return thisApi.QuerySwapGroup(hDC, group, out barrier.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QuerySwapGroup(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> group, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* barrier)
        {
            // SpanOverloader
            return thisApi.QuerySwapGroup(hDC, out group.GetPinnableReference(), barrier);
        }

        public static unsafe Silk.NET.Core.Bool32 QuerySwapGroup(this NVSwapGroup thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> group, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> barrier)
        {
            // SpanOverloader
            return thisApi.QuerySwapGroup(hDC, out group.GetPinnableReference(), out barrier.GetPinnableReference());
        }

    }
}

