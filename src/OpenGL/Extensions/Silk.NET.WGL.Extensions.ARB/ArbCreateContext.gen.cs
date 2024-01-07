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
    [Extension("ARB_create_context")]
    public unsafe partial class ArbCreateContext : NativeExtension<WGL>
    {
        public const string ExtensionName = "ARB_create_context";
        [NativeApi(EntryPoint = "wglCreateContextAttribsARB", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateContextAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* attribList);

        [NativeApi(EntryPoint = "wglCreateContextAttribsARB", Convention = CallingConvention.Winapi)]
        public partial nint CreateContextAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int attribList);

        public ArbCreateContext(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

