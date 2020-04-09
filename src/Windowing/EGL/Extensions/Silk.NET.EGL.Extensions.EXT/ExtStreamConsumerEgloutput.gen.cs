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

namespace Silk.NET.EGL.Extensions.EXT
{
    [Extension("EXT_stream_consumer_egloutput")]
    public abstract unsafe partial class ExtStreamConsumerEgloutput : NativeExtension<EGL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "eglStreamConsumerOutputEXT")]
        public abstract bool StreamConsumerOutput([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] IntPtr layer);

        public unsafe bool StreamConsumerOutput([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] int layer)
        {
            // IntPtrOverloader
            return StreamConsumerOutput(new IntPtr(dpy), new IntPtr(stream), new IntPtr(layer));
        }

        public ExtStreamConsumerEgloutput(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

