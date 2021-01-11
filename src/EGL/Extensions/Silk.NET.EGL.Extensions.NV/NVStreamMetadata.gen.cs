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
    [Extension("NV_stream_metadata")]
    public unsafe partial class NVStreamMetadata : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_metadata";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV")]
        public unsafe partial int QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV")]
        public partial int QueryDisplayAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV")]
        public unsafe partial int QueryStreamMetadata([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV")]
        public partial int QueryStreamMetadata<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV")]
        public unsafe partial int SetStreamMetadata([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV")]
        public partial int SetStreamMetadata<T0>([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        public NVStreamMetadata(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

