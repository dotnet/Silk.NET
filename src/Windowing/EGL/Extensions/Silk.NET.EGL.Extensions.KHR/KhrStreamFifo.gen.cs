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

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream_fifo")]
    public abstract unsafe partial class KhrStreamFifo : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_fifo";
        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR")]
        public abstract unsafe bool QueryStreamTime([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR")]
        public abstract bool QueryStreamTime([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<ulong> value);

        public unsafe bool QueryStreamTime([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value)
        {
            // IntPtrOverloader
            return QueryStreamTime(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public unsafe bool QueryStreamTime([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] Span<ulong> value)
        {
            // IntPtrOverloader
            return QueryStreamTime(new IntPtr(dpy), new IntPtr(stream), attribute, value);
        }

        public KhrStreamFifo(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

