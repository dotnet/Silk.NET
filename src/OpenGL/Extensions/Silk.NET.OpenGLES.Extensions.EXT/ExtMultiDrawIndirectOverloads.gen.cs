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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtMultiDrawIndirectOverloads
    {
        public static unsafe void MultiDrawArraysIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirect(mode, in indirect.GetPinnableReference(), drawcount, stride);
        }

        public static unsafe void MultiDrawArraysIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirect(mode, in indirect.GetPinnableReference(), drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), drawcount, stride);
        }

    }
}

