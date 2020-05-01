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
    [Extension("NV_post_sub_buffer")]
    public abstract unsafe partial class NVPostSubBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_post_sub_buffer";
        [NativeApi(EntryPoint = "eglPostSubBufferNV")]
        public abstract bool PostSubBuffer([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int width, [Flow(FlowDirection.In)] int height);

        public unsafe bool PostSubBuffer([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int surface, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int width, [Flow(FlowDirection.In)] int height)
        {
            // IntPtrOverloader
            return PostSubBuffer(new IntPtr(dpy), new IntPtr(surface), x, y, width, height);
        }

        public NVPostSubBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

