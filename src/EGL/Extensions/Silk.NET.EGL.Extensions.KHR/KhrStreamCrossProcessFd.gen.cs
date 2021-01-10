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
    [Extension("KHR_stream_cross_process_fd")]
    public unsafe partial class KhrStreamCrossProcessFd : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_cross_process_fd";
        [NativeApi(EntryPoint = "eglCreateStreamFromFileDescriptorKHR")]
        public partial nint CreateStreamFromFileDescriptor([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] int file_descriptor);

        [NativeApi(EntryPoint = "eglGetStreamFileDescriptorKHR")]
        public partial int GetStreamFileDescriptor([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream);

        public KhrStreamCrossProcessFd(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

