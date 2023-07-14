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
        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<sbyte> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<short> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

        public static unsafe void SecondaryColor3(this ExtSecondaryColor thisApi, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> v)
        {
            // SpanOverloader
            thisApi.SecondaryColor3(in v.GetPinnableReference());
        }

    }
}

