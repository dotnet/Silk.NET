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
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [Extension("KHR_gl_event")]
    public unsafe partial class KhrGlEvent : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_gl_event";
        [NativeApi(EntryPoint = "clCreateEventFromGLsyncKHR")]
        public unsafe partial IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateEventFromGLsyncKHR")]
        public partial IntPtr CreateEventFromGLsync([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.Out)] out int errcode_ret);

        public KhrGlEvent(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

