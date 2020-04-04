// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_draw_buffers_blend")]
    public abstract unsafe partial class AmdDrawBuffersBlend : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD")]
        public abstract void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD")]
        public abstract void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD modeRGB, [Flow(FlowDirection.In)] AMD modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncIndexedAMD")]
        public abstract void BlendFuncIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD src, [Flow(FlowDirection.In)] AMD dst);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD")]
        public abstract void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD")]
        public abstract void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD")]
        public abstract void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD")]
        public abstract void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        public AmdDrawBuffersBlend(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

