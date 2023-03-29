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

namespace Silk.NET.OpenCL.Extensions.EXT
{
    public static class ExtImageRequirementsInfoOverloads
    {
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemProperties* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<MemProperties> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] ImageRequirementsInfo param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum* properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, properties, flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ImageFormat* image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, image_format, in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ImageDesc* image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), image_desc, param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] nuint* param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, param_value_size_ret);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum, EXT) are deprecated in favour of the \"grouped\" enums (MemProperties, MemFlags, ImageRequirementsInfo). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetImageRequirementsInfo<T0>(this ExtImageRequirementsInfo thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] ReadOnlySpan<CLEnum> properties, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] ReadOnlySpan<ImageFormat> image_format, [Flow(FlowDirection.In)] ReadOnlySpan<ImageDesc> image_desc, [Flow(FlowDirection.In)] EXT param_name, [Flow(FlowDirection.In)] nuint param_value_size, [Flow(FlowDirection.Out)] Span<T0> param_value, [Flow(FlowDirection.Out)] Span<nuint> param_value_size_ret) where T0 : struct
        {
            // SpanOverloader
            fixed (void* param_valueSpp = param_value)
                return thisApi.GetImageRequirementsInfo(context, in properties.GetPinnableReference(), flags, in image_format.GetPinnableReference(), in image_desc.GetPinnableReference(), param_name, param_value_size, param_valueSpp, out param_value_size_ret.GetPinnableReference());
        }

    }
}

