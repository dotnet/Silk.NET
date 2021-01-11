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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream")]
    public unsafe partial class KhrStream : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream";
        [NativeApi(EntryPoint = "eglCreateStreamKHR")]
        public unsafe partial nint CreateStream([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamKHR")]
        public partial nint CreateStream([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in int attrib_list);

        [NativeApi(EntryPoint = "eglDestroyStreamKHR")]
        public partial int DestroyStream([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream);

        [NativeApi(EntryPoint = "eglQueryStreamKHR")]
        public unsafe partial int QueryStream([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryStreamKHR")]
        public partial int QueryStream([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] out int value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR")]
        public unsafe partial int QueryStreamu64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR")]
        public partial int QueryStreamu64([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] out ulong value);

        [NativeApi(EntryPoint = "eglStreamAttribKHR")]
        public partial int StreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] int value);

        public KhrStream(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

