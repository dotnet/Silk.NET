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
    [Extension("NV_stream_consumer_eglimage")]
    public unsafe partial class NVStreamConsumerEglimage : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_consumer_eglimage";
        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public unsafe partial int QueryStreamConsumerEvent([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] NV* @event, [Flow(FlowDirection.Out)] nint* aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public unsafe partial int QueryStreamConsumerEvent([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] NV* @event, [Flow(FlowDirection.Out)] out nint aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public unsafe partial int QueryStreamConsumerEvent([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] out NV @event, [Flow(FlowDirection.Out)] nint* aux);

        [NativeApi(EntryPoint = "eglQueryStreamConsumerEventNV")]
        public partial int QueryStreamConsumerEvent([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ulong timeout, [Flow(FlowDirection.Out)] out NV @event, [Flow(FlowDirection.Out)] out nint aux);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV")]
        public unsafe partial int StreamAcquireImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.Out)] nint* pImage, [Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglStreamAcquireImageNV")]
        public partial int StreamAcquireImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.Out)] out nint pImage, [Flow(FlowDirection.In)] nint sync);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public unsafe partial int StreamImageConsumerConnect([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public unsafe partial int StreamImageConsumerConnect([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] ulong* modifiers, [Flow(FlowDirection.Out)] out nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public unsafe partial int StreamImageConsumerConnect([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamImageConsumerConnectNV")]
        public partial int StreamImageConsumerConnect([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] int num_modifiers, [Flow(FlowDirection.Out)] out ulong modifiers, [Flow(FlowDirection.Out)] out nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamReleaseImageNV")]
        public partial int StreamReleaseImage([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] nint image, [Flow(FlowDirection.In)] nint sync);

        public NVStreamConsumerEglimage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

