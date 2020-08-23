// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_draw_buffers_blend")]
    public unsafe partial class ArbDrawBuffersBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_buffers_blend";
        [NativeApi(EntryPoint = "glBlendEquationiARB")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glBlendEquationiARB")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB modeRGB, [Flow(FlowDirection.In)] ARB modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] ARB modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB src, [Flow(FlowDirection.In)] ARB dst);

        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] ARB dst);

        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        public ArbDrawBuffersBlend(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

