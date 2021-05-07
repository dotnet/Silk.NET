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
    public static class KhrSuggestedLocalWorkSizeOverloads
    {
        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.Out)] Span<nuint> suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset, global_work_size, out suggested_local_work_size.GetPinnableReference());
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.Out)] nuint* suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), suggested_local_work_size);
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] nuint* global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.Out)] Span<nuint> suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, global_work_offset, in global_work_size.GetPinnableReference(), out suggested_local_work_size.GetPinnableReference());
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.Out)] nuint* suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, suggested_local_work_size);
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] nuint* global_work_size, [Flow(FlowDirection.Out)] Span<nuint> suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), global_work_size, out suggested_local_work_size.GetPinnableReference());
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.Out)] nuint* suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), suggested_local_work_size);
        }

        public static unsafe int GetKernelSuggestedLocalWorkSize(this KhrSuggestedLocalWorkSize thisApi, [Flow(FlowDirection.In)] nint command_queue, [Flow(FlowDirection.In)] nint kernel, [Flow(FlowDirection.In)] uint work_dim, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_offset, [Flow(FlowDirection.In)] ReadOnlySpan<nuint> global_work_size, [Flow(FlowDirection.Out)] Span<nuint> suggested_local_work_size)
        {
            // SpanOverloader
            return thisApi.GetKernelSuggestedLocalWorkSize(command_queue, kernel, work_dim, in global_work_offset.GetPinnableReference(), in global_work_size.GetPinnableReference(), out suggested_local_work_size.GetPinnableReference());
        }

    }
}

