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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtBlendFuncExtendedOverloads
    {
        public static unsafe void BindFragDataLocation(this ExtBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocation(program, color, in name.GetPinnableReference());
        }

        public static unsafe void BindFragDataLocationIndexed(this ExtBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocationIndexed(program, colorNumber, index, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataIndex(this ExtBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataIndex(program, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ExtBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ExtBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

    }
}

