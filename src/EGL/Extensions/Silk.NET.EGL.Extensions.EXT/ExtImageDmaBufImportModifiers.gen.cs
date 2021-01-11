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
    [Extension("EXT_image_dma_buf_import_modifiers")]
    public unsafe partial class ExtImageDmaBufImportModifiers : NativeExtension<EGL>
    {
        public const string ExtensionName = "EXT_image_dma_buf_import_modifiers";
        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public unsafe partial int QueryDmaBufFormats([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] int* formats, [Flow(FlowDirection.Out)] int* num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public unsafe partial int QueryDmaBufFormats([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] int* formats, [Flow(FlowDirection.Out)] out int num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public unsafe partial int QueryDmaBufFormats([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] out int formats, [Flow(FlowDirection.Out)] int* num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufFormatsEXT")]
        public partial int QueryDmaBufFormats([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int max_formats, [Flow(FlowDirection.Out)] out int formats, [Flow(FlowDirection.Out)] out int num_formats);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] int* external_only, [Flow(FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] int* external_only, [Flow(FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] out int external_only, [Flow(FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] out int external_only, [Flow(FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] int* external_only, [Flow(FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] int* external_only, [Flow(FlowDirection.Out)] out int num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public unsafe partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] out int external_only, [Flow(FlowDirection.Out)] int* num_modifiers);

        [NativeApi(EntryPoint = "eglQueryDmaBufModifiersEXT")]
        public partial int QueryDmaBufModifiers([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] int max_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] out int external_only, [Flow(FlowDirection.Out)] out int num_modifiers);

        public ExtImageDmaBufImportModifiers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

