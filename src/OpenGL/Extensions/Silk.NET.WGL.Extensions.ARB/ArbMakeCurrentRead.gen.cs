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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.ARB
{
    [Extension("ARB_make_current_read")]
    public unsafe partial class ArbMakeCurrentRead : NativeExtension<WGL>
    {
        public const string ExtensionName = "ARB_make_current_read";
        [NativeApi(EntryPoint = "wglGetCurrentReadDCARB", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentReadDC();

        [NativeApi(EntryPoint = "wglMakeContextCurrentARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeContextCurrent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDrawDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hReadDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrc);

        public ArbMakeCurrentRead(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

