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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_output_base")]
    public unsafe partial class ExtOutputBase : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_output_base";
        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] out nint layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] out nint layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] nint* layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public unsafe partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] out nint layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] int* num_layers);

        [NativeApi(EntryPoint = "eglGetOutputLayersEXT")]
        public partial int GetOutputLayers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] out nint layers, [Flow(FlowDirection.In)] int max_layers, [Flow(FlowDirection.Out)] out int num_layers);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] out nint ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list, [Flow(FlowDirection.Out)] out nint ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] nint* ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public unsafe partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] out nint ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] int* num_ports);

        [NativeApi(EntryPoint = "eglGetOutputPortsEXT")]
        public partial int GetOutputPorts([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list, [Flow(FlowDirection.Out)] out nint ports, [Flow(FlowDirection.In)] int max_ports, [Flow(FlowDirection.Out)] out int num_ports);

        [NativeApi(EntryPoint = "eglOutputLayerAttribEXT")]
        public partial int OutputLayerAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglOutputPortAttribEXT")]
        public partial int OutputPortAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT")]
        public unsafe partial int QueryOutputLayerAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerAttribEXT")]
        public partial int QueryOutputLayerAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT")]
        public unsafe partial byte* QueryOutputLayerString([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputLayerStringEXT")]
        public partial string QueryOutputLayerStringS([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint layer, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT")]
        public unsafe partial int QueryOutputPortAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryOutputPortAttribEXT")]
        public partial int QueryOutputPortAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT")]
        public unsafe partial byte* QueryOutputPortString([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "eglQueryOutputPortStringEXT")]
        public partial string QueryOutputPortStringS([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint port, [Flow(FlowDirection.In)] int name);

        public ExtOutputBase(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

