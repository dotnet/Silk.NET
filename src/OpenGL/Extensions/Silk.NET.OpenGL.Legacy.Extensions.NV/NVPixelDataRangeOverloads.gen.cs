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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVPixelDataRangeOverloads
    {
        public static unsafe void PixelDataRange<T0>(this NVPixelDataRange thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PixelDataRange(target, length, in pointer.GetPinnableReference());
        }

        public static unsafe void PixelDataRange<T0>(this NVPixelDataRange thisApi, [Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.PixelDataRange(target, length, in pointer.GetPinnableReference());
        }

    }
}

