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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftSpatialAnchorOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<SpatialAnchorMSFT> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorMsft(session, createInfo, ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoMSFT> createInfo, [Count(Count = 0)] SpatialAnchorMSFT* anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorMsft(session, in createInfo.GetPinnableReference(), anchor);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<SpatialAnchorMSFT> anchor)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorMsft(session, in createInfo.GetPinnableReference(), ref anchor.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorSpaceMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] SpatialAnchorSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorSpaceMsft(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorSpaceMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorSpaceMsft(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialAnchorSpaceMsft(this MsftSpatialAnchor thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpatialAnchorSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialAnchorSpaceMsft(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

    }
}

