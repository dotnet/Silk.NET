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
    public static class IntelSharingFormatQueryD3d10Overloads
    {
        public static unsafe int GetSupportedD3D10TextureFormats(this IntelSharingFormatQueryD3d10 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* d3d10_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D10TextureFormats(context, flags, image_type, num_entries, d3d10_formats, out num_texture_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedD3D10TextureFormats(this IntelSharingFormatQueryD3d10 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> d3d10_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D10TextureFormats(context, flags, image_type, num_entries, out d3d10_formats.GetPinnableReference(), num_texture_formats);
        }

        public static unsafe int GetSupportedD3D10TextureFormats(this IntelSharingFormatQueryD3d10 thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> d3d10_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D10TextureFormats(context, flags, image_type, num_entries, out d3d10_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

    }
}

