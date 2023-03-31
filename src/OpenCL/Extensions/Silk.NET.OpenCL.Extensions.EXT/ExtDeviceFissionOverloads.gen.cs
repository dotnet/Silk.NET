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
    public static class ExtDeviceFissionOverloads
    {
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DevicePartitionProperty* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DevicePartitionProperty> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DevicePartitionProperty> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DevicePartitionProperty> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DevicePartitionProperty> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        [Obsolete("The \"ungrouped\" enums (EXT) are deprecated in favour of the \"grouped\" enums (DevicePartitionProperty). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint in_device, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num_entries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> out_devices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

