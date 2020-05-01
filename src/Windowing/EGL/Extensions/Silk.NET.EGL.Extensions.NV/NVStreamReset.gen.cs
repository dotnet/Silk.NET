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
    [Extension("NV_stream_reset")]
    public abstract unsafe partial class NVStreamReset : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_reset";
        [NativeApi(EntryPoint = "eglResetStreamNV")]
        public abstract bool ResetStream([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream);

        public unsafe bool ResetStream([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream)
        {
            // IntPtrOverloader
            return ResetStream(new IntPtr(dpy), new IntPtr(stream));
        }

        public NVStreamReset(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

