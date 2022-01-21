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
    [Extension("EXT_draw_buffers_indexed")]
    public unsafe partial class ExtDrawBuffersIndexed : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers_indexed";
        [NativeApi(EntryPoint = "glBlendEquationiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glBlendEquationiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] EXT dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] EXT dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Boolean r, [Flow(FlowDirection.In)] Boolean g, [Flow(FlowDirection.In)] Boolean b, [Flow(FlowDirection.In)] Boolean a);

        [NativeApi(EntryPoint = "glDisableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public ExtDrawBuffersIndexed(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

