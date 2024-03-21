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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_buffers")]
    public unsafe partial class ExtDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in EXT bufs);

        public unsafe void DrawBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> bufs)
        {
            // ImplicitCountSpanOverloader
            DrawBuffers((uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public ExtDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

