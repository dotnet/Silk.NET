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
    [Extension("KHR_egl_event")]
    public unsafe partial class KhrEglEvent : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_egl_event";
        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR")]
        public unsafe partial nint CreateEventFromEglsync([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] nint display, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR")]
        public partial nint CreateEventFromEglsync([Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] nint display, [Flow(FlowDirection.Out)] out int errcode_ret);

        public KhrEglEvent(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

