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

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_drm_image")]
    public abstract unsafe partial class MesaDrmImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_drm_image";
        [NativeApi(EntryPoint = "eglCreateDRMImageMESA")]
        public abstract unsafe IntPtr CreateDrmimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateDRMImageMESA")]
        public abstract IntPtr CreateDrmimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<int> attrib_list);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public abstract unsafe bool ExportDrmimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] int* stride);

        [NativeApi(EntryPoint = "eglExportDRMImageMESA")]
        public abstract bool ExportDrmimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] Span<int> stride);

        public unsafe IntPtr CreateDrmimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateDrmimage(new IntPtr(dpy), attrib_list);
        }

        public unsafe IntPtr CreateDrmimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateDrmimage(new IntPtr(dpy), attrib_list);
        }

        public unsafe bool ExportDrmimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] int* name, [Flow(FlowDirection.Out)] int* handle, [Flow(FlowDirection.Out)] int* stride)
        {
            // IntPtrOverloader
            return ExportDrmimage(new IntPtr(dpy), new IntPtr(image), name, handle, stride);
        }

        public unsafe bool ExportDrmimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] Span<int> name, [Flow(FlowDirection.Out)] Span<int> handle, [Flow(FlowDirection.Out)] Span<int> stride)
        {
            // IntPtrOverloader
            return ExportDrmimage(new IntPtr(dpy), new IntPtr(image), name, handle, stride);
        }

        public MesaDrmImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

