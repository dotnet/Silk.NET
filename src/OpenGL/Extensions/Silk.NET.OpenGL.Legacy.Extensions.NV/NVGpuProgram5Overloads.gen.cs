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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVGpuProgram5Overloads
    {
        public static unsafe void GetProgramSubroutineParameter(this NVGpuProgram5 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Span<uint> param)
        {
            // SpanOverloader
            thisApi.GetProgramSubroutineParameter(target, index, out param.GetPinnableReference());
        }

        public static unsafe void ProgramSubroutineParameters(this NVGpuProgram5 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramSubroutineParameters(target, count, in @params.GetPinnableReference());
        }

    }
}

