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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    public static class SgisTextureFilter4Overloads
    {
        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureFilterSGIS filter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIS filter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureFilterSGIS filter, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

    }
}

