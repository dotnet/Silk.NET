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
    public static class IntelSharingFormatQueryD3d11Overloads
    {
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, d3d11_formats, out num_texture_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), num_texture_formats);
        }

        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, d3d11_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemFlags flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, d3d11_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MemObjectType image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, d3d11_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedD3D11TextureFormats(this IntelSharingFormatQueryD3d11 thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CLEnum flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint image_type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint plane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> d3d11_formats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedD3D11TextureFormats(context, flags, image_type, plane, num_entries, out d3d11_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

    }
}

