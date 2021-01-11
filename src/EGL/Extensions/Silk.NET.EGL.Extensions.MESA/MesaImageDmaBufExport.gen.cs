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
    [Extension("MESA_image_dma_buf_export")]
    public unsafe partial class MesaImageDmaBufExport : NativeExtension<EGL>
    {
        public const string ExtensionName = "MESA_image_dma_buf_export";
        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] out int strides, [Flow(FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] out int strides, [Flow(FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public unsafe partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fds, [Flow(FlowDirection.Out)] out int strides, [Flow(FlowDirection.Out)] int* offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public partial int ExportDmabufimage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fds, [Flow(FlowDirection.Out)] out int strides, [Flow(FlowDirection.Out)] out int offsets);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] out int num_planes, [Flow(FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] out int num_planes, [Flow(FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] out ulong modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public unsafe partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fourcc, [Flow(FlowDirection.Out)] out int num_planes, [Flow(FlowDirection.Out)] ulong* modifiers);

        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public partial int ExportDmabufimageQuery([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.Out)] out int fourcc, [Flow(FlowDirection.Out)] out int num_planes, [Flow(FlowDirection.Out)] out ulong modifiers);

        public MesaImageDmaBufExport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

