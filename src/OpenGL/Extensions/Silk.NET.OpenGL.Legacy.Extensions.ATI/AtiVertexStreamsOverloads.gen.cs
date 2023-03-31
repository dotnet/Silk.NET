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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiVertexStreamsOverloads
    {
        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void NormalStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.NormalStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream1(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream1(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream2(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream2(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream3(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream3(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

        public static unsafe void VertexStream4(this AtiVertexStreams thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexStreamATI stream, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> coords)
        {
            // SpanOverloader
            thisApi.VertexStream4(stream, in coords.GetPinnableReference());
        }

    }
}

