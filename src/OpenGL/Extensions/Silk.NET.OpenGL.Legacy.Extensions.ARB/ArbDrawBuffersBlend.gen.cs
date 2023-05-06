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
    [Extension("ARB_draw_buffers_blend")]
    public unsafe partial class ArbDrawBuffersBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_buffers_blend";
        [NativeApi(EntryPoint = "glBlendEquationiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glBlendEquationiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dst);

        [NativeApi(EntryPoint = "glBlendFunciARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dst);

        [NativeApi(EntryPoint = "glBlendFunciARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        public ArbDrawBuffersBlend(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

