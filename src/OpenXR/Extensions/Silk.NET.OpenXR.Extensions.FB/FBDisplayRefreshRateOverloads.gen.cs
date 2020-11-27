// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.FB
{
    public static class FBDisplayRefreshRateOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] uint* displayRefreshRateCountOutput, [Count(Computed = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, displayRefreshRateCountOutput, ref displayRefreshRates.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] Span<uint> displayRefreshRateCountOutput, [Count(Computed = "displayRefreshRateCapacityInput")] float* displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, ref displayRefreshRateCountOutput.GetPinnableReference(), displayRefreshRates);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result EnumerateDisplayRefreshRatesFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint displayRefreshRateCapacityInput, [Count(Count = 0)] Span<uint> displayRefreshRateCountOutput, [Count(Computed = "displayRefreshRateCapacityInput")] Span<float> displayRefreshRates)
        {
            // SpanOverloader
            return thisApi.EnumerateDisplayRefreshRatesFB(session, displayRefreshRateCapacityInput, ref displayRefreshRateCountOutput.GetPinnableReference(), ref displayRefreshRates.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetDisplayRefreshRateFB(this FBDisplayRefreshRate thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] Span<float> displayRefreshRate)
        {
            // SpanOverloader
            return thisApi.GetDisplayRefreshRateFB(session, ref displayRefreshRate.GetPinnableReference());
        }

    }
}

