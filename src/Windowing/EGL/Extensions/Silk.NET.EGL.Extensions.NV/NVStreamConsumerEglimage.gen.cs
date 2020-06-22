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
    [Extension("NV_stream_consumer_eglimage")]
    public abstract unsafe partial class NVStreamConsumerEglimage : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_consumer_eglimage";
        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public abstract unsafe int QueryStreamConsumerEvent([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] NV* @event, [Flow(FlowDirection.Out)] IntPtr* aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public abstract int QueryStreamConsumerEvent([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] Span<NV> @event, [Flow(FlowDirection.Out)] Span<IntPtr> aux);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV")]
        public abstract unsafe bool StreamAcquireImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.Out)] IntPtr* pImage, [Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV")]
        public abstract bool StreamAcquireImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.Out)] Span<IntPtr> pImage, [Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public abstract unsafe bool StreamImageConsumerConnect([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] IntPtr* attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public abstract bool StreamImageConsumerConnect([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<IntPtr> attrib_list);

        [NativeApi(EntryPoint = "eglStreamReleaseImageNV")]
        public abstract bool StreamReleaseImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] IntPtr sync);

        public unsafe int QueryStreamConsumerEvent([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] NV* @event, [Flow(FlowDirection.Out)] IntPtr* aux)
        {
            // IntPtrOverloader
            return QueryStreamConsumerEvent(new IntPtr(dpy), new IntPtr(stream), timeout, @event, aux);
        }

        public unsafe int QueryStreamConsumerEvent([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] Span<NV> @event, [Flow(FlowDirection.Out)] Span<IntPtr> aux)
        {
            // IntPtrOverloader
            return QueryStreamConsumerEvent(new IntPtr(dpy), new IntPtr(stream), timeout, @event, aux);
        }

        public unsafe bool StreamAcquireImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.Out)] IntPtr* pImage, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return StreamAcquireImage(new IntPtr(dpy), new IntPtr(stream), pImage, new IntPtr(sync));
        }

        public unsafe bool StreamAcquireImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.Out)] Span<IntPtr> pImage, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return StreamAcquireImage(new IntPtr(dpy), new IntPtr(stream), pImage, new IntPtr(sync));
        }

        public unsafe bool StreamImageConsumerConnect([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] IntPtr* attrib_list)
        {
            // IntPtrOverloader
            return StreamImageConsumerConnect(new IntPtr(dpy), new IntPtr(stream), num_modifiers, modifiers, attrib_list);
        }

        public unsafe bool StreamImageConsumerConnect([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] Span<ulong> modifiers, [Flow(FlowDirection.Out)] Span<IntPtr> attrib_list)
        {
            // IntPtrOverloader
            return StreamImageConsumerConnect(new IntPtr(dpy), new IntPtr(stream), num_modifiers, modifiers, attrib_list);
        }

        public unsafe bool StreamReleaseImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] int sync)
        {
            // IntPtrOverloader
            return StreamReleaseImage(new IntPtr(dpy), new IntPtr(stream), new IntPtr(image), new IntPtr(sync));
        }

        public NVStreamConsumerEglimage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

