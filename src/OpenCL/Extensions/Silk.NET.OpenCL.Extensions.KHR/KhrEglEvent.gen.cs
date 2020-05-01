// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_egl_event")]
    public abstract unsafe partial class KhrEglEvent : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_egl_event";
        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR")]
        public abstract unsafe IntPtr CreateEventFromEglsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] IntPtr display, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR")]
        public abstract IntPtr CreateEventFromEglsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] IntPtr display, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        public unsafe IntPtr CreateEventFromEglsync([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int display, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateEventFromEglsync(new IntPtr(context), new IntPtr(sync), new IntPtr(display), errcode_ret);
        }

        public unsafe IntPtr CreateEventFromEglsync([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.In)] int display, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateEventFromEglsync(new IntPtr(context), new IntPtr(sync), new IntPtr(display), errcode_ret);
        }

        public KhrEglEvent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

