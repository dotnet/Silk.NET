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

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_drm_image")]
    public unsafe partial class MesaDrmImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_drm_image";
        [NativeApi(EntryPoint = "eglCreateDRMImageMESA")]
        public unsafe partial nint CreateDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateDRMImageMESA")]
        public partial nint CreateDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] out int handle, [Flow(FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] out int handle, [Flow(FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] out int stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public unsafe partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int name, [Flow(FlowDirection.Out)] out int handle, [Flow(FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public partial int ExportDrmimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int name, [Flow(FlowDirection.Out)] out int handle, [Flow(FlowDirection.Out)] out int stride);

        public MesaDrmImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

