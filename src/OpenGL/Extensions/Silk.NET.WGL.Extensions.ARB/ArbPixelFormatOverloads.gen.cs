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

namespace Silk.NET.WGL.Extensions.ARB
{
    public static class ArbPixelFormatOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, piAttribIList, in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), pfAttribFList, nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, piFormats, out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), nNumFormats);
        }

        public static unsafe Silk.NET.Core.Bool32 ChoosePixelFormat(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> nNumFormats)
        {
            // SpanOverloader
            return thisApi.ChoosePixelFormat(hdc, in piAttribIList.GetPinnableReference(), in pfAttribFList.GetPinnableReference(), nMaxFormats, out piFormats.GetPinnableReference(), out nNumFormats.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, out piValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, in piAttributes.GetPinnableReference(), piValues);
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, in piAttributes.GetPinnableReference(), out piValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, piAttributes, out pfValues.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, in piAttributes.GetPinnableReference(), pfValues);
        }

        public static unsafe Silk.NET.Core.Bool32 GetPixelFormatAttrib(this ArbPixelFormat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> pfValues)
        {
            // SpanOverloader
            return thisApi.GetPixelFormatAttrib(hdc, iPixelFormat, iLayerPlane, nAttributes, in piAttributes.GetPinnableReference(), out pfValues.GetPinnableReference());
        }

    }
}

