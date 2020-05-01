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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream")]
    public abstract unsafe partial class KhrStream : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream";
        [NativeApi(EntryPoint = "eglCreateStreamKHR")]
        public abstract unsafe IntPtr CreateStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamKHR")]
        public abstract IntPtr CreateStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<int> attrib_list);

        [NativeApi(EntryPoint = "eglDestroyStreamKHR")]
        public abstract bool DestroyStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        [NativeApi(EntryPoint = "eglQueryStreamKHR")]
        public abstract unsafe bool QueryStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] int* value);

        [NativeApi(EntryPoint = "eglQueryStreamKHR")]
        public abstract bool QueryStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<int> value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR")]
        public abstract unsafe bool QueryStreamu64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamu64KHR")]
        public abstract bool QueryStreamu64([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<ulong> value);

        [NativeApi(EntryPoint = "eglStreamAttribKHR")]
        public abstract bool StreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] int value);

        public unsafe IntPtr CreateStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateStream(new IntPtr(dpy), attrib_list);
        }

        public unsafe IntPtr CreateStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateStream(new IntPtr(dpy), attrib_list);
        }

        public unsafe bool DestroyStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return DestroyStream(new IntPtr(dpy), new IntPtr(stream));
        }

        public unsafe bool QueryStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] int* value)
        {
            // IntPtrOverloader
            return QueryStream(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool QueryStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<int> value)
        {
            // IntPtrOverloader
            return QueryStream(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool QueryStreamu64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value)
        {
            // IntPtrOverloader
            return QueryStreamu64(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool QueryStreamu64([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<ulong> value)
        {
            // IntPtrOverloader
            return QueryStreamu64(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool StreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] int value)
        {
            // IntPtrOverloader
            return StreamAttrib(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public KhrStream(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

