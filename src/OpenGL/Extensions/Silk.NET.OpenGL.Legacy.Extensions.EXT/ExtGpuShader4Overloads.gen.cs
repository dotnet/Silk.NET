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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtGpuShader4Overloads
    {
        public static unsafe void BindFragDataLocation(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocation(program, color, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataLocation(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataLocation(program, in name.GetPinnableReference());
        }

        public static unsafe void GetUniform(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetUniform(program, location, out @params.GetPinnableReference());
        }

        public static unsafe void Uniform1(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform1(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform2(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform2(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform3(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform3(location, count, in value.GetPinnableReference());
        }

        public static unsafe void Uniform4(this ExtGpuShader4 thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> value)
        {
            // SpanOverloader
            thisApi.Uniform4(location, count, in value.GetPinnableReference());
        }

    }
}

