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
    public static class ArbBindlessTextureOverloads
    {
        public static unsafe void GetVertexAttribL(this ArbBindlessTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this ArbBindlessTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramUniformHandle(this ArbBindlessTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // SpanOverloader
            thisApi.ProgramUniformHandle(program, location, count, in values.GetPinnableReference());
        }

        public static unsafe void UniformHandle(this ArbBindlessTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.UniformHandle(location, count, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribL1(this ArbBindlessTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL1(index, in v.GetPinnableReference());
        }

    }
}

