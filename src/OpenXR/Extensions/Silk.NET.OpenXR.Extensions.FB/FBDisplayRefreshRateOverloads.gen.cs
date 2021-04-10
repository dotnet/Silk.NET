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
    public static class FBDisplayRefreshRateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] uint* displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, ref displayRefreshRates.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] Span<uint> displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] float* displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, ref displayRefreshRateCountOutput.GetPinnableReference(), displayRefreshRates);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] Span<uint> displayRefreshRateCountOutput, [Count(Parameter = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, ref displayRefreshRateCountOutput.GetPinnableReference(), ref displayRefreshRates.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDisplayRefreshRateFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<float> displayRefreshRate)
        {
            // SpanOverloader
            return thisApi.GetDisplayRefreshRateFB(session, ref displayRefreshRate.GetPinnableReference());
        }

    }
}

