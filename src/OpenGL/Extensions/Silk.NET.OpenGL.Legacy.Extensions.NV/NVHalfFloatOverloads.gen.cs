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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVHalfFloatOverloads
    {
        public static unsafe void Color3h(this NVHalfFloat thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Color3h(in v.GetPinnableReference());
        }

        public static unsafe void Color4h(this NVHalfFloat thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Color4h(in v.GetPinnableReference());
        }

        public static unsafe void FogCoordh(this NVHalfFloat thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> fog)
        {
            // SpanOverloader
            thisApi.FogCoordh(in fog.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4h(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4h(target, in v.GetPinnableReference());
        }

        public static unsafe void Normal3h(this NVHalfFloat thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Normal3h(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3h(this NVHalfFloat thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3h(in v.GetPinnableReference());
        }

        public static unsafe void TexCoord1h(this NVHalfFloat thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.TexCoord1h(in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2h(this NVHalfFloat thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.TexCoord2h(in v.GetPinnableReference());
        }

        public static unsafe void TexCoord3h(this NVHalfFloat thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.TexCoord3h(in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4h(this NVHalfFloat thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.TexCoord4h(in v.GetPinnableReference());
        }

        public static unsafe void Vertex2h(this NVHalfFloat thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Vertex2h(in v.GetPinnableReference());
        }

        public static unsafe void Vertex3h(this NVHalfFloat thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Vertex3h(in v.GetPinnableReference());
        }

        public static unsafe void Vertex4h(this NVHalfFloat thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.Vertex4h(in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib1h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib1h(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib2h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib2h(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib3h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib3h(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttrib4h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttrib4h(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs1h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs1h(index, n, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs2h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs2h(index, n, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs3h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs3h(index, n, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribs4h(this NVHalfFloat thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> v)
        {
            // SpanOverloader
            thisApi.VertexAttribs4h(index, n, in v.GetPinnableReference());
        }

        public static unsafe void VertexWeighth(this NVHalfFloat thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Half> weight)
        {
            // SpanOverloader
            thisApi.VertexWeighth(in weight.GetPinnableReference());
        }

    }
}

