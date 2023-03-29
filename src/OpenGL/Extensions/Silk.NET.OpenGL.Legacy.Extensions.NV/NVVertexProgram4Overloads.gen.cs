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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVVertexProgram4Overloads
    {
        public static unsafe void GetVertexAttribI(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void VertexAttribI1(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI1(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI2(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI2(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI3(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI3(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribIPointer<T0>(this NVVertexProgram4 thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.VertexAttribIPointer(index, size, type, stride, pointerSpp);
        }

    }
}

