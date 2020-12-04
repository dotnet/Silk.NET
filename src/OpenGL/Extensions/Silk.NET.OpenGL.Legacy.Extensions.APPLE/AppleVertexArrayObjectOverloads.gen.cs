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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    public static class AppleVertexArrayObjectOverloads
    {
        public static unsafe void DeleteVertexArrays(this AppleVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> arrays)
        {
            // SpanOverloader
            thisApi.DeleteVertexArrays(n, in arrays.GetPinnableReference());
        }

        public static unsafe void GenVertexArrays(this AppleVertexArrayObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays)
        {
            // SpanOverloader
            thisApi.GenVertexArrays(n, out arrays.GetPinnableReference());
        }

    }
}

