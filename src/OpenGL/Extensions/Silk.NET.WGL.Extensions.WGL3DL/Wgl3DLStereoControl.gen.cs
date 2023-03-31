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

namespace Silk.NET.WGL.Extensions.WGL3DL
{
    [Extension("3DL_stereo_control")]
    public unsafe partial class Wgl3DLStereoControl : NativeExtension<WGL>
    {
        public const string ExtensionName = "3DL_stereo_control";
        [NativeApi(EntryPoint = "wglSetStereoEmitterState3DL", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetStereoEmitterState3DL([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uState);

        public Wgl3DLStereoControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

