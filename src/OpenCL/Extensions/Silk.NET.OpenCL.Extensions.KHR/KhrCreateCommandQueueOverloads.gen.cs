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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    public static class KhrCreateCommandQueueOverloads
    {
        public static unsafe IntPtr CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] KHR* properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, properties, out errcode_ret.GetPinnableReference());
        }

        public static unsafe IntPtr CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), errcode_ret);
        }

        public static unsafe IntPtr CreateCommandQueueWithProperties(this KhrCreateCommandQueue thisApi, [Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr device, [Flow(FlowDirection.In)] ReadOnlySpan<KHR> properties, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // SpanOverloader
            return thisApi.CreateCommandQueueWithProperties(context, device, in properties.GetPinnableReference(), out errcode_ret.GetPinnableReference());
        }

    }
}

