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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelCreateBufferWithPropertiesOverloads
    {
        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe nint CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

