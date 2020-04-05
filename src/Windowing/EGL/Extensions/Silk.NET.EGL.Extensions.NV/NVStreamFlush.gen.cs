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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_stream_flush")]
    public abstract unsafe partial class NVStreamFlush : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglStreamFlushNV")]
        public abstract bool StreamFlush([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        public unsafe bool StreamFlush([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return StreamFlush(new IntPtr(dpy), new IntPtr(stream));
        }

        public NVStreamFlush(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

