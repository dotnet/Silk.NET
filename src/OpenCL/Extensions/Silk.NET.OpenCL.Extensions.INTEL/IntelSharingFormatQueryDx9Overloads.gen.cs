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
    public static class IntelSharingFormatQueryDx9Overloads
    {
        public static unsafe int GetSupportedDX9MediaSurfaceFormats(this IntelSharingFormatQueryDx9 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* dx9_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedDX9MediaSurfaceFormats(context, flags, image_type, plane, num_entries, dx9_formats, out num_surface_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedDX9MediaSurfaceFormats(this IntelSharingFormatQueryDx9 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> dx9_formats, [Flow(FlowDirection.Out)] uint* num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedDX9MediaSurfaceFormats(context, flags, image_type, plane, num_entries, out dx9_formats.GetPinnableReference(), num_surface_formats);
        }

        public static unsafe int GetSupportedDX9MediaSurfaceFormats(this IntelSharingFormatQueryDx9 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint plane, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> dx9_formats, [Flow(FlowDirection.Out)] Span<uint> num_surface_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedDX9MediaSurfaceFormats(context, flags, image_type, plane, num_entries, out dx9_formats.GetPinnableReference(), out num_surface_formats.GetPinnableReference());
        }

    }
}

