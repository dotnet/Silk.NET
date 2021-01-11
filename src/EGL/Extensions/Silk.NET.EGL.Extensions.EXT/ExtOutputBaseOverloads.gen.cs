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
    public static class ExtOutputBaseOverloads
    {
        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, layers, max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] Span<nint> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, out layers.GetPinnableReference(), max_layers, num_layers);
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] Span<nint> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, attrib_list, out layers.GetPinnableReference(), max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), layers, max_layers, num_layers);
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), layers, max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] Span<nint> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), out layers.GetPinnableReference(), max_layers, num_layers);
        }

        public static unsafe int GetOutputLayers(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] Span<nint> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers)
        {
            // SpanOverloader
            return thisApi.GetOutputLayers(dpy, in attrib_list.GetPinnableReference(), out layers.GetPinnableReference(), max_layers, out num_layers.GetPinnableReference());
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, ports, max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] Span<nint> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, out ports.GetPinnableReference(), max_ports, num_ports);
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] Span<nint> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, attrib_list, out ports.GetPinnableReference(), max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), ports, max_ports, num_ports);
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), ports, max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] Span<nint> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), out ports.GetPinnableReference(), max_ports, num_ports);
        }

        public static unsafe int GetOutputPorts(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list, [Flow(FlowDirection.Out)] Span<nint> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports)
        {
            // SpanOverloader
            return thisApi.GetOutputPorts(dpy, in attrib_list.GetPinnableReference(), out ports.GetPinnableReference(), max_ports, out num_ports.GetPinnableReference());
        }

        public static unsafe int QueryOutputLayerAttrib(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryOutputLayerAttrib(dpy, layer, attribute, out value.GetPinnableReference());
        }

        public static unsafe int QueryOutputPortAttrib(this ExtOutputBase thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryOutputPortAttrib(dpy, port, attribute, out value.GetPinnableReference());
        }

    }
}

