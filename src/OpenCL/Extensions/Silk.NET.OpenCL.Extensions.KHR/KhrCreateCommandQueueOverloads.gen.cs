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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrCreateCommandQueueOverloads
    {
        public static unsafe nint CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

