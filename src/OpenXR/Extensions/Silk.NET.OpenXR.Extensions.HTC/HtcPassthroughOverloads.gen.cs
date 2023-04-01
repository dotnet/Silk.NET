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
    public static class HtcPassthroughOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughHtc(this HtcPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PassthroughCreateInfoHTC* createInfo, [Count(Count = 0)] Span<PassthroughHTC> passthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughHtc(session, createInfo, ref passthrough.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughHtc(this HtcPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCreateInfoHTC> createInfo, [Count(Count = 0)] PassthroughHTC* passthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughHtc(session, in createInfo.GetPinnableReference(), passthrough);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreatePassthroughHtc(this HtcPassthrough thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PassthroughCreateInfoHTC> createInfo, [Count(Count = 0)] Span<PassthroughHTC> passthrough)
        {
            // SpanOverloader
            return thisApi.CreatePassthroughHtc(session, in createInfo.GetPinnableReference(), ref passthrough.GetPinnableReference());
        }

    }
}

