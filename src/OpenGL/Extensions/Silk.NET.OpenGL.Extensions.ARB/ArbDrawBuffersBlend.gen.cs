// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_draw_buffers_blend")]
    public abstract unsafe partial class ArbDrawBuffersBlend : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationiARB")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB modeRGB, [Flow(FlowDirection.In)] ARB modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB src, [Flow(FlowDirection.In)] ARB dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] ARB srcRGB, [Flow(FlowDirection.In)] ARB dstRGB, [Flow(FlowDirection.In)] ARB srcAlpha, [Flow(FlowDirection.In)] ARB dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationiARB")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateiARB")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFunciARB")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateiARB")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        public ArbDrawBuffersBlend(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

