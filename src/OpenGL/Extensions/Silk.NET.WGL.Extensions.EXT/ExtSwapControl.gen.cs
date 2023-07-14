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

namespace Silk.NET.WGL.Extensions.EXT
{
    [Extension("EXT_swap_control")]
    public unsafe partial class ExtSwapControl : NativeExtension<WGL>
    {
        public const string ExtensionName = "EXT_swap_control";
        [NativeApi(EntryPoint = "wglGetSwapIntervalEXT", Convention = CallingConvention.Winapi)]
        public partial int GetSwapInterval();

        [NativeApi(EntryPoint = "wglSwapIntervalEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SwapInterval([Flow(Silk.NET.Core.Native.FlowDirection.In)] int interval);

        public ExtSwapControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

