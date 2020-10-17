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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbTransposeMatrixOverloads
    {
        public static unsafe void LoadTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.LoadTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void LoadTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.LoadTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void MultTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MultTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void MultTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MultTransposeMatrix(in m.GetPinnableReference());
        }

    }
}

