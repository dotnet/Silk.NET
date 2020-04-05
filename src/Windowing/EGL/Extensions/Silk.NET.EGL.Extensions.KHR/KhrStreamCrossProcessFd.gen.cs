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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream_cross_process_fd")]
    public abstract unsafe partial class KhrStreamCrossProcessFd : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglCreateStreamFromFileDescriptorKHR")]
        public abstract IntPtr CreateStreamFromFileDescriptor([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] int file_descriptor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglGetStreamFileDescriptorKHR")]
        public abstract int GetStreamFileDescriptor([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        public unsafe IntPtr CreateStreamFromFileDescriptor([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int file_descriptor)
        {
            // IntPtrOverloader
            return CreateStreamFromFileDescriptor(new IntPtr(dpy), file_descriptor);
        }

        public unsafe int GetStreamFileDescriptor([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return GetStreamFileDescriptor(new IntPtr(dpy), new IntPtr(stream));
        }

        public KhrStreamCrossProcessFd(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

