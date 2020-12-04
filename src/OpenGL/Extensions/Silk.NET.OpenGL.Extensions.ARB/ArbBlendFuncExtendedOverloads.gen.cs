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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbBlendFuncExtendedOverloads
    {
        public static unsafe void BindFragDataLocationIndexed(this ArbBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocationIndexed(program, colorNumber, index, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataIndex(this ArbBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataIndex(program, in name.GetPinnableReference());
        }

    }
}

