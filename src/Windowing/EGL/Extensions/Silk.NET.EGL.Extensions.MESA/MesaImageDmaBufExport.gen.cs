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

namespace Silk.NET.EGL.Extensions.MESA
{
    [Extension("MESA_image_dma_buf_export")]
    public abstract unsafe partial class MesaImageDmaBufExport : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public abstract unsafe bool ExportDmabufimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] int* offsets);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglExportDMABUFImageMESA")]
        public abstract bool ExportDmabufimage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] Span<int> offsets);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public abstract unsafe bool ExportDmabufimageQuery([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] ulong* modifiers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglExportDMABUFImageQueryMESA")]
        public abstract bool ExportDmabufimageQuery([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers);

        public unsafe bool ExportDmabufimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] int* fds, [Flow(FlowDirection.Out)] int* strides, [Flow(FlowDirection.Out)] int* offsets)
        {
            // IntPtrOverloader
            return ExportDmabufimage(new IntPtr(dpy), new IntPtr(image), fds, strides, offsets);
        }

        public unsafe bool ExportDmabufimage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] Span<int> fds, [Flow(FlowDirection.Out)] Span<int> strides, [Flow(FlowDirection.Out)] Span<int> offsets)
        {
            // IntPtrOverloader
            return ExportDmabufimage(new IntPtr(dpy), new IntPtr(image), fds, strides, offsets);
        }

        public unsafe bool ExportDmabufimageQuery([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] int* fourcc, [Flow(FlowDirection.Out)] int* num_planes, [Flow(FlowDirection.Out)] ulong* modifiers)
        {
            // IntPtrOverloader
            return ExportDmabufimageQuery(new IntPtr(dpy), new IntPtr(image), fourcc, num_planes, modifiers);
        }

        public unsafe bool ExportDmabufimageQuery([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.Out)] Span<int> fourcc, [Flow(FlowDirection.Out)] Span<int> num_planes, [Flow(FlowDirection.Out)] Span<ulong> modifiers)
        {
            // IntPtrOverloader
            return ExportDmabufimageQuery(new IntPtr(dpy), new IntPtr(image), fourcc, num_planes, modifiers);
        }

        public MesaImageDmaBufExport(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

