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
    [Extension("KHR_stream_attrib")]
    public abstract unsafe partial class KhrStreamAttrib : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_attrib";
        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR")]
        public abstract unsafe IntPtr CreateStreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR")]
        public abstract IntPtr CreateStreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR")]
        public abstract unsafe bool QueryStreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] IntPtr* value);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR")]
        public abstract bool QueryStreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value);

        [NativeApi(EntryPoint = "eglSetStreamAttribKHR")]
        public abstract bool SetStreamAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] IntPtr value);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR")]
        public abstract unsafe bool StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR")]
        public abstract bool StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR")]
        public abstract unsafe bool StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] IntPtr* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR")]
        public abstract bool StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list);

        public unsafe IntPtr CreateStreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamAttrib(new IntPtr(dpy), attrib_list);
        }

        public unsafe IntPtr CreateStreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamAttrib(new IntPtr(dpy), attrib_list);
        }

        public unsafe bool QueryStreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] IntPtr* value)
        {
            // IntPtrOverloader
            return QueryStreamAttrib(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool QueryStreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<IntPtr> value)
        {
            // IntPtrOverloader
            return QueryStreamAttrib(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool SetStreamAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] int value)
        {
            // IntPtrOverloader
            return SetStreamAttrib(new IntPtr(dpy), new IntPtr(stream), attribute, new IntPtr(value));
        }

        public unsafe bool StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerAcquireAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public unsafe bool StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerAcquireAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public unsafe bool StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerReleaseAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public unsafe bool StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return StreamConsumerReleaseAttrib(new IntPtr(dpy), new IntPtr(stream), attrib_list);
        }

        public KhrStreamAttrib(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

