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
    public static class ArbVertexArrayObjectOverloads
    {
        public static unsafe void DeleteVertexArrays(this ArbVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> arrays)
        {
            // SpanOverloader
            thisApi.DeleteVertexArrays(n, in arrays.GetPinnableReference());
        }

        public static unsafe void DeleteVertexArrays(this ArbVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexArray> arrays)
        {
            // SpanOverloader
            thisApi.DeleteVertexArrays(n, in arrays.GetPinnableReference());
        }

        public static unsafe void GenVertexArrays(this ArbVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> arrays)
        {
            // SpanOverloader
            thisApi.GenVertexArrays(n, out arrays.GetPinnableReference());
        }

        public static unsafe void GenVertexArrays(this ArbVertexArrayObject thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // SpanOverloader
            thisApi.GenVertexArrays(n, out arrays.GetPinnableReference());
        }

    }
}

