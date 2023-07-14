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
    [Extension("KHR_terminate_context")]
    public unsafe partial class KhrTerminateContext : NativeExtension<CL>
    {
        public const string ExtensionName = "KHR_terminate_context";
        [NativeApi(EntryPoint = "clTerminateContextKHR", Convention = CallingConvention.Winapi)]
        public partial int TerminateContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint context);

        public KhrTerminateContext(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

