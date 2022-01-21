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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_draw_buffers_blend")]
    public unsafe partial class AmdDrawBuffersBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_draw_buffers_blend";
        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD mode);

        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD modeRGB, [Flow(FlowDirection.In)] AMD modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] AMD modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFuncIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD src, [Flow(FlowDirection.In)] AMD dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        public AmdDrawBuffersBlend(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

