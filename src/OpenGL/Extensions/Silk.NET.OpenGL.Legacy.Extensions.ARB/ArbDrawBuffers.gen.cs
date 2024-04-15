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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_buffers")]
    public unsafe partial class ArbDrawBuffers : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_buffers";
        [NativeApi(EntryPoint = "glDrawBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ARB bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffersARB", Convention = CallingConvention.Winapi)]
        public partial void DrawBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawBufferMode bufs);

        public unsafe void DrawBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ARB> bufs)
        {
            // ImplicitCountSpanOverloader
            DrawBuffers((uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public unsafe void DrawBuffers([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // ImplicitCountSpanOverloader
            DrawBuffers((uint) bufs.Length, in bufs.GetPinnableReference());
        }

        public ArbDrawBuffers(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

