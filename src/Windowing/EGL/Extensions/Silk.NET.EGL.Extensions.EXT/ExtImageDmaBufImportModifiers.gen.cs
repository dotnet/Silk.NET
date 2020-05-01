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
    [Extension("EXT_image_dma_buf_import_modifiers")]
    public abstract unsafe partial class ExtImageDmaBufImportModifiers : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_image_dma_buf_import_modifiers";
        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public abstract unsafe bool QueryDmaBufFormats([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] int* formats, [Flow(FlowDirection.Out)] int* num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public abstract bool QueryDmaBufFormats([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] Span<int> formats, [Flow(FlowDirection.Out)] Span<int> num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public abstract unsafe bool QueryDmaBufModifiers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] bool* external_only, [Flow(FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public abstract bool QueryDmaBufModifiers([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers);

        public unsafe bool QueryDmaBufFormats([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] int* formats, [Flow(FlowDirection.Out)] int* num_formats)
        {
            // IntPtrOverloader
            return QueryDmaBufFormats(new IntPtr(dpy), max_formats, formats, num_formats);
        }

        public unsafe bool QueryDmaBufFormats([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] Span<int> formats, [Flow(FlowDirection.Out)] Span<int> num_formats)
        {
            // IntPtrOverloader
            return QueryDmaBufFormats(new IntPtr(dpy), max_formats, formats, num_formats);
        }

        public unsafe bool QueryDmaBufModifiers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] bool* external_only, [Flow(FlowDirection.Out)] int* num_modifiers)
        {
            // IntPtrOverloader
            return QueryDmaBufModifiers(new IntPtr(dpy), format, max_modifiers, modifiers, external_only, num_modifiers);
        }

        public unsafe bool QueryDmaBufModifiers([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<bool> external_only, [Flow(FlowDirection.Out)] Span<int> num_modifiers)
        {
            // IntPtrOverloader
            return QueryDmaBufModifiers(new IntPtr(dpy), format, max_modifiers, modifiers, external_only, num_modifiers);
        }

        public ExtImageDmaBufImportModifiers(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

