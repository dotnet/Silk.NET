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

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_delay_before_swap")]
    public unsafe partial class NVDelayBeforeSwap : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_delay_before_swap";
        [NativeApi(EntryPoint = "wglDelayBeforeSwapNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DelayBeforeSwap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float seconds);

        public NVDelayBeforeSwap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

