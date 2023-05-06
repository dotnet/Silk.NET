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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    public static class SunVertexOverloads
    {
        public static unsafe void Color3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color3fVertex3(c, in v.GetPinnableReference());
        }

        public static unsafe void Color3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color3fVertex3(in c.GetPinnableReference(), v);
        }

        public static unsafe void Color3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color3fVertex3(in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(c, n, in v.GetPinnableReference());
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(c, in n.GetPinnableReference(), v);
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(in c.GetPinnableReference(), n, v);
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void Color4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4fNormal3fVertex3(in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex2(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex2(c, in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex2(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex2(in c.GetPinnableReference(), v);
        }

        public static unsafe void Color4ubVertex2(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex2(in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex2(this SunVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex2(c, in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex3(c, in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex3(in c.GetPinnableReference(), v);
        }

        public static unsafe void Color4ubVertex3(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex3(in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void Color4ubVertex3(this SunVertex thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Color4ubVertex3(c, in v.GetPinnableReference());
        }

        public static unsafe void Normal3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Normal3fVertex3(n, in v.GetPinnableReference());
        }

        public static unsafe void Normal3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.Normal3fVertex3(in n.GetPinnableReference(), v);
        }

        public static unsafe void Normal3fVertex3(this SunVertex thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.Normal3fVertex3(in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(rc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(rc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4fNormal3fVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(rc, c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, v);
        }

        public static unsafe void ReplacementCodeuiColor4ubVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiColor4ubVertex3(in rc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(rc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiNormal3fVertex3(in rc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(rc, in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, tc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(rc, in tc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), tc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), n, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fNormal3fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, tc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, in tc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), tc, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), tc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, tc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, in tc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(rc, in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), tc, v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), tc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiTexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiTexCoord2fVertex3(in rc.GetPinnableReference(), in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(rc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(in rc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(in rc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleListSUN* rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(rc, in v.GetPinnableReference());
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(in rc.GetPinnableReference(), v);
        }

        public static unsafe void ReplacementCodeuiVertex3(this SunVertex thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> rc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ReplacementCodeuiVertex3(in rc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(tc, c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(tc, in c.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(tc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(in tc.GetPinnableReference(), c, v);
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(in tc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4fNormal3fVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(tc, c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(tc, in c.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(tc, in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(tc, c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), c, v);
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), in c.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), c, v);
        }

        public static unsafe void TexCoord2fColor4ubVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fColor4ubVertex3(in tc.GetPinnableReference(), c, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(tc, n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(tc, in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(tc, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(in tc.GetPinnableReference(), n, v);
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(in tc.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(in tc.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fNormal3fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fNormal3fVertex3(in tc.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fVertex3(tc, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord2fVertex3(in tc.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord2fVertex3(this SunVertex thisApi, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord2fVertex3(in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, c, n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, c, in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, in c.GetPinnableReference(), n, v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(tc, in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), c, n, v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), c, n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), c, in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), c, in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), in c.GetPinnableReference(), n, v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), in c.GetPinnableReference(), n, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord4fColor4fNormal3fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> c, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> n, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fColor4fNormal3fVertex4(in tc.GetPinnableReference(), in c.GetPinnableReference(), in n.GetPinnableReference(), in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fVertex4(tc, in v.GetPinnableReference());
        }

        public static unsafe void TexCoord4fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v)
        {
            // SpanOverloader
            thisApi.TexCoord4fVertex4(in tc.GetPinnableReference(), v);
        }

        public static unsafe void TexCoord4fVertex4(this SunVertex thisApi, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> tc, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.TexCoord4fVertex4(in tc.GetPinnableReference(), in v.GetPinnableReference());
        }

    }
}

