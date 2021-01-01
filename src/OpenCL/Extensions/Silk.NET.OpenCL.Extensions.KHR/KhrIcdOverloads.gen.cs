// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
    public static class KhrIcdOverloads
    {
        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, platforms, out num_platforms.GetPinnableReference());
        }

        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> platforms, [Flow(FlowDirection.Out)] uint* num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, out platforms.GetPinnableReference(), num_platforms);
        }

        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> platforms, [Flow(FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, out platforms.GetPinnableReference(), out num_platforms.GetPinnableReference());
        }

    }
}

