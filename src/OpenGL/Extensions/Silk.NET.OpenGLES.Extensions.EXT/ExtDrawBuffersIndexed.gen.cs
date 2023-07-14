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
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glBlendEquationiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquation([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dst);

        [NativeApi(EntryPoint = "glBlendFunciEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFunc([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glColorMaskiEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Disable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT", Convention = CallingConvention.Winapi)]
        public partial void Enable([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabled([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        public ExtDrawBuffersIndexed(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

