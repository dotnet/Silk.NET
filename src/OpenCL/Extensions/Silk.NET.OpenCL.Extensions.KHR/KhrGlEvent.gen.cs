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
    [Extension("KHR_gl_event")]
    public abstract unsafe partial class KhrGlEvent : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_event";
        [NativeApi(EntryPoint = "clCreateEventFromGLsyncKHR")]
        public abstract unsafe IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateEventFromGLsyncKHR")]
        public abstract IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.Out)] Span<int> errcode_ret);

        public unsafe IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateEventFromGLsync(new IntPtr(context), new IntPtr(sync), errcode_ret);
        }

        public unsafe IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] int sync, [Flow(FlowDirection.Out)] Span<int> errcode_ret)
        {
            // IntPtrOverloader
            return CreateEventFromGLsync(new IntPtr(context), new IntPtr(sync), errcode_ret);
        }

        public KhrGlEvent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

