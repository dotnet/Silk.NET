// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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
        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateEventFromEglsync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint display, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateEventFromEGLSyncKHR", Convention = CallingConvention.Winapi)]
        public partial nint CreateEventFromEglsync([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint sync, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint display, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int errcode_ret);

        public KhrEglEvent(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

