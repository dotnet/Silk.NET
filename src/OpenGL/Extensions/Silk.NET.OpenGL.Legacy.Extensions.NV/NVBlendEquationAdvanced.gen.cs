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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_blend_equation_advanced")]
    public unsafe partial class NVBlendEquationAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_blend_equation_advanced";
        [NativeApi(EntryPoint = "glBlendBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void BlendBarrier();

        [NativeApi(EntryPoint = "glBlendParameteriNV", Convention = CallingConvention.Winapi)]
        public partial void BlendParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int value);

        public NVBlendEquationAdvanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

