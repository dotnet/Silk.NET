// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_output_base")]
    public abstract unsafe partial class ExtOutputBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_output_base";
        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public abstract unsafe bool GetOutputLayers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list, [Flow(FlowDirection.Out)] IntPtr* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public abstract bool GetOutputLayers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public abstract unsafe bool GetOutputPorts([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list, [Flow(FlowDirection.Out)] IntPtr* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public abstract bool GetOutputPorts([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports);

        [NativeApi(EntryPoint = "eglOutputLayerAttribEXT")]
        public abstract bool OutputLayerAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] IntPtr value);

        [NativeApi(EntryPoint = "eglOutputPortAttribEXT")]
        public abstract bool OutputPortAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] IntPtr value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT")]
        public abstract unsafe bool QueryOutputLayerAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT")]
        public abstract bool QueryOutputLayerAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT")]
        public abstract unsafe char* QueryOutputLayerString([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr layer, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT")]
        public abstract unsafe bool QueryOutputPortAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT")]
        public abstract bool QueryOutputPortAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT")]
        public abstract unsafe char* QueryOutputPortString([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr port, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT")]
        public abstract string QueryOutputLayerStringS([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr layer, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT")]
        public abstract string QueryOutputPortStringS([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr port, [Flow(FlowDirection.In)] int name);

        public unsafe bool GetOutputLayers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list, [Flow(FlowDirection.Out)] IntPtr* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers)
        {
            // IntPtrOverloader
            return GetOutputLayers(new IntPtr(dpy), attrib_list, layers, max_layers, num_layers);
        }

        public unsafe bool GetOutputLayers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] Span<int> num_layers)
        {
            // IntPtrOverloader
            return GetOutputLayers(new IntPtr(dpy), attrib_list, layers, max_layers, num_layers);
        }

        public unsafe bool GetOutputPorts([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list, [Flow(FlowDirection.Out)] IntPtr* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports)
        {
            // IntPtrOverloader
            return GetOutputPorts(new IntPtr(dpy), attrib_list, ports, max_ports, num_ports);
        }

        public unsafe bool GetOutputPorts([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list, [Flow(FlowDirection.Out)] Span<IntPtr> ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] Span<int> num_ports)
        {
            // IntPtrOverloader
            return GetOutputPorts(new IntPtr(dpy), attrib_list, ports, max_ports, num_ports);
        }

        public unsafe bool OutputLayerAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] int value)
        {
            // IntPtrOverloader
            return OutputLayerAttrib(new IntPtr(dpy), new IntPtr(layer), attribute, new IntPtr(value));
        }

        public unsafe bool OutputPortAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] int value)
        {
            // IntPtrOverloader
            return OutputPortAttrib(new IntPtr(dpy), new IntPtr(port), attribute, new IntPtr(value));
        }

        public unsafe bool QueryOutputLayerAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryOutputLayerAttrib(new IntPtr(dpy), new IntPtr(layer), attribute, value);
        }

        public unsafe bool QueryOutputLayerAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryOutputLayerAttrib(new IntPtr(dpy), new IntPtr(layer), attribute, value);
        }

        public unsafe char* QueryOutputLayerString([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryOutputLayerString(new IntPtr(dpy), new IntPtr(layer), name);
        }

        public unsafe bool QueryOutputPortAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryOutputPortAttrib(new IntPtr(dpy), new IntPtr(port), attribute, value);
        }

        public unsafe bool QueryOutputPortAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryOutputPortAttrib(new IntPtr(dpy), new IntPtr(port), attribute, value);
        }

        public unsafe char* QueryOutputPortString([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int port, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryOutputPortString(new IntPtr(dpy), new IntPtr(port), name);
        }

        public unsafe string QueryOutputLayerStringS([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryOutputLayerStringS(new IntPtr(dpy), new IntPtr(layer), name);
        }

        public unsafe string QueryOutputPortStringS([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int port, [Flow(FlowDirection.In)] int name)
        {
            // IntPtrOverloader
            return QueryOutputPortStringS(new IntPtr(dpy), new IntPtr(port), name);
        }

        public ExtOutputBase(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

