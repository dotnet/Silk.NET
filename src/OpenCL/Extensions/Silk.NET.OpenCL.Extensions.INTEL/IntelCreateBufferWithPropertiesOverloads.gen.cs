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

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelCreateBufferWithPropertiesOverloads
    {
        public static unsafe IntPtr CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe IntPtr CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, properties, flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, errcode_ret);
        }

        public static unsafe IntPtr CreateBufferWithProperties(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, host_ptr, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), errcode_ret);
        }

        public static unsafe IntPtr CreateBufferWithProperties<T0>(this IntelCreateBufferWithProperties thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] ReadOnlySpan<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.CreateBufferWithProperties(context, in properties.GetPinnableReference(), flags, size, out host_ptr.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

