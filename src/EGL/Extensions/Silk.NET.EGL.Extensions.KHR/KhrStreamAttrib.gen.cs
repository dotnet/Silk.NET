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
    [Extension("KHR_stream_attrib")]
    public unsafe partial class KhrStreamAttrib : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_attrib";
        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR")]
        public unsafe partial nint CreateStreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamAttribKHR")]
        public partial nint CreateStreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR")]
        public unsafe partial int QueryStreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] nint* value);

        [NativeApi(EntryPoint = "eglQueryStreamAttribKHR")]
        public partial int QueryStreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] out nint value);

        [NativeApi(EntryPoint = "eglSetStreamAttribKHR")]
        public partial int SetStreamAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.In)] nint value);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR")]
        public unsafe partial int StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerAcquireAttribKHR")]
        public partial int StreamConsumerAcquireAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] in nint attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR")]
        public unsafe partial int StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] nint* attrib_list);

        [NativeApi(EntryPoint = "eglStreamConsumerReleaseAttribKHR")]
        public partial int StreamConsumerReleaseAttrib([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] in nint attrib_list);

        public KhrStreamAttrib(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

