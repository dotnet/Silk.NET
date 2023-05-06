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
        public partial void BlendEquationIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD mode);

        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendEquationSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFuncIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD src, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparateIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor srcAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dstAlpha);

        public AmdDrawBuffersBlend(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

