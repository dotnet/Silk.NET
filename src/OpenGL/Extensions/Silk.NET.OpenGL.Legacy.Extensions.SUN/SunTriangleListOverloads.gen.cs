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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    public static class SunTriangleListOverloads
    {
        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<uint> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ushort> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<byte> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

    }
}

