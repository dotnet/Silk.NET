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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbMultitextureOverloads
    {
        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord1(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord1(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord2(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord2(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord3(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord3(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] ARB target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

        public static unsafe void MultiTexCoord4(this ArbMultitexture thisApi, [Flow(FlowDirection.In)] TextureUnit target, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.MultiTexCoord4(target, in v.GetPinnableReference());
        }

    }
}

