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

namespace Silk.NET.OpenXR.Extensions.HTC
{
    public static class HtcAnchorOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorHtc(this HtcAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoHTC* createInfo, [Count(Count = 0)] Span<Space> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorHtc(session, createInfo, ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorHtc(this HtcAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoHTC> createInfo, [Count(Count = 0)] Space* anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorHtc(session, in createInfo.GetPinnableReference(), anchor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorHtc(this HtcAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoHTC> createInfo, [Count(Count = 0)] Span<Space> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorHtc(session, in createInfo.GetPinnableReference(), ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSpatialAnchorNameHtc(this HtcAnchor thisApi, [Count(Count = 0)] Space anchor, [Count(Count = 0)] Span<SpatialAnchorNameHTC> name)
        {
            // SpanOverloader
            return thisApi.GetSpatialAnchorNameHtc(anchor, ref name.GetPinnableReference());
        }

    }
}

