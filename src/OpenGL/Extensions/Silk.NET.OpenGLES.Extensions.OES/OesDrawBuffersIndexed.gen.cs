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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_draw_buffers_indexed")]
    public unsafe partial class OesDrawBuffersIndexed : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_draw_buffers_indexed";
        [NativeApi(EntryPoint = "glBlendEquationiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES mode);

        [NativeApi(EntryPoint = "glBlendEquationiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] OES target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        public OesDrawBuffersIndexed(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

