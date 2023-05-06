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

namespace Silk.NET.WGL.Extensions.OML
{
    public static class OmlSyncControlOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetMscRate(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(hdc, numerator, out denominator.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetMscRate(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(hdc, out numerator.GetPinnableReference(), denominator);
        }

        public static unsafe Silk.NET.Core.Bool32 GetMscRate(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> numerator, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> denominator)
        {
            // SpanOverloader
            return thisApi.GetMscRate(hdc, out numerator.GetPinnableReference(), out denominator.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, ust, msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, ust, out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, ust, out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, out ust.GetPinnableReference(), msc, sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, out ust.GetPinnableReference(), msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, out ust.GetPinnableReference(), out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 GetSyncValues(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.GetSyncValues(hdc, out ust.GetPinnableReference(), out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, ust, msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, ust, out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, ust, out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, out ust.GetPinnableReference(), msc, sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, out ust.GetPinnableReference(), msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, out ust.GetPinnableReference(), out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForMsc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_msc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long divisor, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long remainder, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForMsc(hdc, target_msc, divisor, remainder, out ust.GetPinnableReference(), out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, ust, msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, ust, out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, ust, out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, out ust.GetPinnableReference(), msc, sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, out ust.GetPinnableReference(), msc, out sbc.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, out ust.GetPinnableReference(), out msc.GetPinnableReference(), sbc);
        }

        public static unsafe Silk.NET.Core.Bool32 WaitForSbc(this OmlSyncControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] long target_sbc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> ust, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> msc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> sbc)
        {
            // SpanOverloader
            return thisApi.WaitForSbc(hdc, target_sbc, out ust.GetPinnableReference(), out msc.GetPinnableReference(), out sbc.GetPinnableReference());
        }

    }
}

