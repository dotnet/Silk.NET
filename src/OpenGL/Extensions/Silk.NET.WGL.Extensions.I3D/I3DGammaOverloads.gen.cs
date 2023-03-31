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
    public static class I3DGammaOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, puRed, puGreen, out puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, puRed, out puGreen.GetPinnableReference(), puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, puRed, out puGreen.GetPinnableReference(), out puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, out puRed.GetPinnableReference(), puGreen, puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, out puRed.GetPinnableReference(), puGreen, out puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, out puRed.GetPinnableReference(), out puGreen.GetPinnableReference(), puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableI3D(hDC, iEntries, out puRed.GetPinnableReference(), out puGreen.GetPinnableReference(), out puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetGammaTableParametersI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piValue)
        {
            // SpanOverloader
            return thisApi.GetGammaTableParametersI3D(hDC, iAttribute, out piValue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, puRed, puGreen, in puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, puRed, in puGreen.GetPinnableReference(), puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, puRed, in puGreen.GetPinnableReference(), in puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, in puRed.GetPinnableReference(), puGreen, puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, in puRed.GetPinnableReference(), puGreen, in puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, in puRed.GetPinnableReference(), in puGreen.GetPinnableReference(), puBlue);
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> puBlue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableI3D(hDC, iEntries, in puRed.GetPinnableReference(), in puGreen.GetPinnableReference(), in puBlue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetGammaTableParametersI3D(this I3DGamma thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piValue)
        {
            // SpanOverloader
            return thisApi.SetGammaTableParametersI3D(hDC, iAttribute, in piValue.GetPinnableReference());
        }

    }
}

