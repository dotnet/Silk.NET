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
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES mode);

        [NativeApi(EntryPoint = "glBlendEquationiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES modeRGB, [Flow(FlowDirection.In)] OES modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] OES modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES src, [Flow(FlowDirection.In)] OES dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] OES dst);

        [NativeApi(EntryPoint = "glBlendFunciOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] OES srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] OES dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] OES srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] OES dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiOES", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiOES", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiOES", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiOES", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediOES", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public OesDrawBuffersIndexed(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

