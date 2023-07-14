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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbMultitextureOverloads
    {
        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

    }
}

