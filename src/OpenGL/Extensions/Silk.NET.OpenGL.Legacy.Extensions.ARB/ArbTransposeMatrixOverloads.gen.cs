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
    public static class ArbTransposeMatrixOverloads
    {
        public static unsafe void LoadTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.LoadTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void LoadTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.LoadTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void MultTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> m)
        {
            // SpanOverloader
            thisApi.MultTransposeMatrix(in m.GetPinnableReference());
        }

        public static unsafe void MultTransposeMatrix(this ArbTransposeMatrix thisApi, [Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> m)
        {
            // SpanOverloader
            thisApi.MultTransposeMatrix(in m.GetPinnableReference());
        }

    }
}

