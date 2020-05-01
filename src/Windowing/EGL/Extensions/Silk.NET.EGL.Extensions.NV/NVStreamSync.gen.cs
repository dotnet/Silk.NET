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
    [Extension("NV_stream_sync")]
    public abstract unsafe partial class NVStreamSync : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_stream_sync";
        [NativeApi(EntryPoint = "eglCreateStreamSyncNV")]
        public abstract unsafe IntPtr CreateStreamSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateStreamSyncNV")]
        public abstract IntPtr CreateStreamSync([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Span<int> attrib_list);

        public unsafe IntPtr CreateStreamSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamSync(new IntPtr(dpy), new IntPtr(stream), type, attrib_list);
        }

        public unsafe IntPtr CreateStreamSync([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateStreamSync(new IntPtr(dpy), new IntPtr(stream), type, attrib_list);
        }

        public NVStreamSync(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

