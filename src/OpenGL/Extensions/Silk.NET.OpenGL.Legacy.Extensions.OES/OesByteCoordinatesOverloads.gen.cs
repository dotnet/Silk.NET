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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    public static class OesByteCoordinatesOverloads
    {
        public static unsafe void MultiTexCoord1(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(texture, in coords.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this OesByteCoordinates thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit texture, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(texture, in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord1(this OesByteCoordinates thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.TexCoord1(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord2(this OesByteCoordinates thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.TexCoord2(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord3(this OesByteCoordinates thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.TexCoord3(in coords.GetPinnableReference());
        }

        public static unsafe void TexCoord4(this OesByteCoordinates thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.TexCoord4(in coords.GetPinnableReference());
        }

        public static unsafe void Vertex2(this OesByteCoordinates thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.Vertex2(in coords.GetPinnableReference());
        }

        public static unsafe void Vertex3(this OesByteCoordinates thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.Vertex3(in coords.GetPinnableReference());
        }

        public static unsafe void Vertex4(this OesByteCoordinates thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> coords)
        {
            // SpanOverloader
            thisApi.Vertex4(in coords.GetPinnableReference());
        }

    }
}

