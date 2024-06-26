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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtFutureOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CancelFuture(this ExtFuture thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FutureCancelInfoEXT> cancelInfo)
        {
            // SpanOverloader
            return thisApi.CancelFuture(instance, in cancelInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PollFuture(this ExtFuture thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FuturePollInfoEXT* pollInfo, [Count(Count = 0)] Span<FuturePollResultEXT> pollResult)
        {
            // SpanOverloader
            return thisApi.PollFuture(instance, pollInfo, ref pollResult.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PollFuture(this ExtFuture thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FuturePollInfoEXT> pollInfo, [Count(Count = 0)] FuturePollResultEXT* pollResult)
        {
            // SpanOverloader
            return thisApi.PollFuture(instance, in pollInfo.GetPinnableReference(), pollResult);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result PollFuture(this ExtFuture thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FuturePollInfoEXT> pollInfo, [Count(Count = 0)] Span<FuturePollResultEXT> pollResult)
        {
            // SpanOverloader
            return thisApi.PollFuture(instance, in pollInfo.GetPinnableReference(), ref pollResult.GetPinnableReference());
        }

    }
}

