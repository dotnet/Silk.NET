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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbBindlessTextureOverloads
    {
        public static unsafe void GetVertexAttribL(this ArbBindlessTexture thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this ArbBindlessTexture thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramUniformHandle(this ArbBindlessTexture thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // SpanOverloader
            thisApi.ProgramUniformHandle(program, location, count, in values.GetPinnableReference());
        }

        public static unsafe void UniformHandle(this ArbBindlessTexture thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.UniformHandle(location, count, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribL1(this ArbBindlessTexture thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL1(index, in v.GetPinnableReference());
        }

    }
}

