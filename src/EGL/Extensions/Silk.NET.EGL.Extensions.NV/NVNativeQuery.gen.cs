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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_native_query")]
    public unsafe partial class NVNativeQuery : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_native_query";
        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV")]
        public unsafe partial int QueryNativeDisplay([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] nint* display_id);

        [NativeApi(EntryPoint = "eglQueryNativeDisplayNV")]
        public partial int QueryNativeDisplay([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.Out)] out nint display_id);

        [NativeApi(EntryPoint = "eglQueryNativePixmapNV")]
        public unsafe partial int QueryNativePixmap([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] nint* pixmap);

        [NativeApi(EntryPoint = "eglQueryNativePixmapNV")]
        public partial int QueryNativePixmap([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] out nint pixmap);

        [NativeApi(EntryPoint = "eglQueryNativeWindowNV")]
        public unsafe partial int QueryNativeWindow([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] nint* window);

        [NativeApi(EntryPoint = "eglQueryNativeWindowNV")]
        public partial int QueryNativeWindow([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surf, [Flow(FlowDirection.Out)] out nint window);

        public NVNativeQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

