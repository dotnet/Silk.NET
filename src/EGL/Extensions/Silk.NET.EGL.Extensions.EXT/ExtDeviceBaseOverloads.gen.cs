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

namespace Silk.NET.EGL.Extensions.EXT
{
    public static class ExtDeviceBaseOverloads
    {
        public static unsafe bool QueryDeviceAttrib(this ExtDeviceBase thisApi, [Flow(FlowDirection.In)] nint device, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDeviceAttrib(device, attribute, out value.GetPinnableReference());
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] nint* devices, [Flow(FlowDirection.Out)] Span<int> num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, devices, out num_devices.GetPinnableReference());
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] int* num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, out devices.GetPinnableReference(), num_devices);
        }

        public static unsafe bool QueryDevices(this ExtDeviceBase thisApi, [Flow(FlowDirection.In)] int max_devices, [Flow(FlowDirection.Out)] Span<nint> devices, [Flow(FlowDirection.Out)] Span<int> num_devices)
        {
            // SpanOverloader
            return thisApi.QueryDevices(max_devices, out devices.GetPinnableReference(), out num_devices.GetPinnableReference());
        }

        public static unsafe bool QueryDisplayAttrib(this ExtDeviceBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDisplayAttrib(dpy, attribute, out value.GetPinnableReference());
        }

    }
}

