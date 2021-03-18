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
        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ulong* properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, properties, num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] nint* out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out_devices, out num_devices.GetPinnableReference());
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] uint* num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), num_devices);
        }

        public static unsafe int CreateSubDevices(this ExtDeviceFission thisApi, [Flow(FlowDirection.In)] nint in_device, [Flow(FlowDirection.In)] ReadOnlySpan<ulong> properties, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<nint> out_devices, [Flow(FlowDirection.Out)] Span<uint> num_devices)
        {
            // SpanOverloader
            return thisApi.CreateSubDevices(in_device, in properties.GetPinnableReference(), num_entries, out out_devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

    }
}

