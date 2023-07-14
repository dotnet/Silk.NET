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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    public static class SunTriangleListOverloads
    {
        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<TriangleListSUN> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

        public static unsafe void ReplacementCode(this SunTriangleList thisApi, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> code)
        {
            // SpanOverloader
            thisApi.ReplacementCode(in code.GetPinnableReference());
        }

    }
}

