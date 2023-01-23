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

namespace Silk.NET.OpenXR.Extensions.HTCX
{
    public static class HtcxViveTrackerInteractionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViveTrackerPathsHtcx(this HtcxViveTrackerInteraction thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] uint* pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ViveTrackerPathsHTCX> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateViveTrackerPathsHtcx(instance, pathCapacityInput, pathCountOutput, ref paths.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViveTrackerPathsHtcx(this HtcxViveTrackerInteraction thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] ViveTrackerPathsHTCX* paths)
        {
            // SpanOverloader
            return thisApi.EnumerateViveTrackerPathsHtcx(instance, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), paths);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateViveTrackerPathsHtcx(this HtcxViveTrackerInteraction thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] uint pathCapacityInput, [Count(Count = 0)] Span<uint> pathCountOutput, [Count(Parameter = "pathCapacityInput")] Span<ViveTrackerPathsHTCX> paths)
        {
            // SpanOverloader
            return thisApi.EnumerateViveTrackerPathsHtcx(instance, pathCapacityInput, ref pathCountOutput.GetPinnableReference(), ref paths.GetPinnableReference());
        }

    }
}

