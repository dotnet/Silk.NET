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

namespace Silk.NET.WGL
{
    public static class WGLOverloads
    {
        public static unsafe int ChoosePixelFormat(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormatDescriptor> pPfd)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hDc, in pPfd.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 DescribeLayerPlane(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int pixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nBytes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<LayerPlaneDescriptor> plpd)
        {
            // SpanOverloader
            return thisApi.DescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, out plpd.GetPinnableReference());
        }

        public static unsafe int DescribePixelFormat(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cjpfd, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PixelFormatDescriptor> ppfd)
        {
            // SpanOverloader
            return thisApi.DescribePixelFormat(hdc, ipfd, cjpfd, out ppfd.GetPinnableReference());
        }

        public static unsafe uint GetEnhMetaFilePixelFormat(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hemf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cbBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<PixelFormatDescriptor> ppfd)
        {
            // SpanOverloader
            return thisApi.GetEnhMetaFilePixelFormat(hemf, cbBuffer, out ppfd.GetPinnableReference());
        }

        public static unsafe int GetLayerPaletteEntries(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> pcr)
        {
            // SpanOverloader
            return thisApi.GetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, out pcr.GetPinnableReference());
        }

        public static unsafe int SetLayerPaletteEntries(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pcr)
        {
            // SpanOverloader
            return thisApi.SetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, in pcr.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetPixelFormat(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PixelFormatDescriptor> ppfd)
        {
            // SpanOverloader
            return thisApi.SetPixelFormat(hdc, ipfd, in ppfd.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 UseFontOutlines(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphMetricsFloat> lpgmf)
        {
            // SpanOverloader
            return thisApi.UseFontOutlines(hDC, first, count, listBase, deviation, extrusion, format, in lpgmf.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 UseFontOutlinesA(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphMetricsFloat> lpgmf)
        {
            // SpanOverloader
            return thisApi.UseFontOutlinesA(hDC, first, count, listBase, deviation, extrusion, format, in lpgmf.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 UseFontOutlinesW(this WGL thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphMetricsFloat> lpgmf)
        {
            // SpanOverloader
            return thisApi.UseFontOutlinesW(hDC, first, count, listBase, deviation, extrusion, format, in lpgmf.GetPinnableReference());
        }

    }
}

