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
    public static class KhrIcdOverloads
    {
        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, platforms, out num_platforms.GetPinnableReference());
        }

        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, out platforms.GetPinnableReference(), num_platforms);
        }

        public static unsafe int IcdGetPlatformIDs(this KhrIcd thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> platforms, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_platforms)
        {
            // SpanOverloader
            return thisApi.IcdGetPlatformIDs(num_entries, out platforms.GetPinnableReference(), out num_platforms.GetPinnableReference());
        }

    }
}

