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
    public static class ArbVertexBufferObjectOverloads
    {
        public static unsafe void BufferData<T0>(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferData(target, size, dataSpp, usage);
        }

        public static unsafe void BufferData<T0>(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferData(target, size, dataSpp, usage);
        }

        public static unsafe void BufferData<T0>(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferData(target, size, dataSpp, usage);
        }

        public static unsafe void BufferSubData<T0>(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.BufferSubData(target, offset, size, dataSpp);
        }

        public static unsafe void DeleteBuffers(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> buffers)
        {
            // SpanOverloader
            thisApi.DeleteBuffers(n, in buffers.GetPinnableReference());
        }

        public static unsafe void DeleteBuffers(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.DeleteBuffers(n, in buffers.GetPinnableReference());
        }

        public static unsafe void GenBuffers(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers)
        {
            // SpanOverloader
            thisApi.GenBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void GenBuffers(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<Buffer> buffers)
        {
            // SpanOverloader
            thisApi.GenBuffers(n, out buffers.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferParameter(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetBufferParameter(target, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetBufferSubData<T0>(this ArbVertexBufferObject thisApi, [Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.GetBufferSubData(target, offset, size, dataSpp);
        }

    }
}

