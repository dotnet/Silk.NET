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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtGpuShader4Overloads
    {
        public static unsafe void BindFragDataLocation(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocation(program, color, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataLocation(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribI(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribI(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*1"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*2"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*3"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count", Expression = "*4"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

        public static unsafe void VertexAttribI1(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI1(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI2(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI2(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI3(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI3(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribI4(this ExtGpuShader4 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.VertexAttribI4(index, in v.GetPinnableReference());
        }

    }
}

