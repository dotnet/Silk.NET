// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void GetTexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] Span<float> weights)
        {
            // SpanOverloader
            thisApi.GetTexFilterFunc(target, filter, out weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

        public static unsafe void TexFilterFunc(this SgisTextureFilter4 thisApi, [Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> weights)
        {
            // SpanOverloader
            thisApi.TexFilterFunc(target, filter, n, in weights.GetPinnableReference());
        }

    }
}

