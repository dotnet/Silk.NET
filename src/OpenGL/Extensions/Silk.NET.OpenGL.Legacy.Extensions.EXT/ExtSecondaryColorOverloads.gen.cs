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
    public static class ExtSecondaryColorOverloads
    {
        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColorPointer<T0>(this ExtSecondaryColor thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : struct
        {
            // SpanOverloader
            fixed (void* pointerSpp = pointer)
                thisApi.SecondaryColorPointer(size, type, stride, pointerSpp);
        }

    }
}

