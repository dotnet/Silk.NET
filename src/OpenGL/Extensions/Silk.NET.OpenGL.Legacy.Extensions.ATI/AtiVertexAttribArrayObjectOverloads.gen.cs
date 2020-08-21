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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiVertexAttribArrayObjectOverloads
    {
        public static unsafe void GetVertexAttribArrayObject(this AtiVertexAttribArrayObject thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribArrayObject(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribArrayObject(this AtiVertexAttribArrayObject thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribArrayObject(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribArrayObject(this AtiVertexAttribArrayObject thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribArrayObject(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribArrayObject(this AtiVertexAttribArrayObject thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribArrayObject(index, pname, out @params.GetPinnableReference());
        }

    }
}

