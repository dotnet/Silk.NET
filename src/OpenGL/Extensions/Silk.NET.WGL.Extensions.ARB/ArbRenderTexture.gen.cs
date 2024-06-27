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
    [Extension("ARB_render_texture")]
    public unsafe partial class ArbRenderTexture : NativeExtension<WGL>
    {
        public const string ExtensionName = "ARB_render_texture";
        [NativeApi(EntryPoint = "wglBindTexImageARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BindTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iBuffer);

        [NativeApi(EntryPoint = "wglReleaseTexImageARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ReleaseTexImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iBuffer);

        [NativeApi(EntryPoint = "wglSetPbufferAttribARB", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetPbufferAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribList);

        [NativeApi(EntryPoint = "wglSetPbufferAttribARB", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetPbufferAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribList);

        public ArbRenderTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

