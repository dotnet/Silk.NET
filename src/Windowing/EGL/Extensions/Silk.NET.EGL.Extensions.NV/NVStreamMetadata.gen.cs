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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_stream_metadata")]
    public abstract unsafe partial class NVStreamMetadata : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_metadata";
        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV")]
        public abstract unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        [NativeApi(EntryPoint = "eglQueryDisplayAttribNV")]
        public abstract bool QueryDisplayAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV")]
        public abstract unsafe bool QueryStreamMetadata([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "eglQueryStreamMetadataNV")]
        public abstract bool QueryStreamMetadata<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV")]
        public abstract unsafe bool SetStreamMetadata([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "eglSetStreamMetadataNV")]
        public abstract bool SetStreamMetadata<T0>([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), attribute, value);
        }

        public unsafe bool QueryDisplayAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryDisplayAttrib(new IntPtr(dpy), attribute, value);
        }

        public unsafe bool QueryStreamMetadata([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            return QueryStreamMetadata(new IntPtr(dpy), new IntPtr(stream), name, n, offset, size, data);
        }

        public unsafe bool QueryStreamMetadata<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] NV name, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return QueryStreamMetadata(new IntPtr(dpy), new IntPtr(stream), name, n, offset, size, data);
        }

        public unsafe bool SetStreamMetadata([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            return SetStreamMetadata(new IntPtr(dpy), new IntPtr(stream), n, offset, size, data);
        }

        public unsafe bool SetStreamMetadata<T0>([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int n, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            return SetStreamMetadata(new IntPtr(dpy), new IntPtr(stream), n, offset, size, data);
        }

        public NVStreamMetadata(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

