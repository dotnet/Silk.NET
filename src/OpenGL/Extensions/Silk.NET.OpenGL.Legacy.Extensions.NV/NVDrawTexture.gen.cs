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
    [Extension("NV_draw_texture")]
    public unsafe partial class NVDrawTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_draw_texture";
        [NativeApi(EntryPoint = "glDrawTextureNV", Convention = CallingConvention.Winapi)]
        public partial void DrawTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float x1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float y1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float s1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float t1);

        public NVDrawTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

