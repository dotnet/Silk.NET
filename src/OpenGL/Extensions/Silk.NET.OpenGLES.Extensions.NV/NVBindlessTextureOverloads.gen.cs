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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVBindlessTextureOverloads
    {
        public static unsafe void ProgramUniformHandle(this NVBindlessTexture thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // SpanOverloader
            thisApi.ProgramUniformHandle(program, location, count, in values.GetPinnableReference());
        }

        public static unsafe void UniformHandle(this NVBindlessTexture thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.UniformHandle(location, count, in value.GetPinnableReference());
        }

    }
}

