// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_draw_buffers_blend")]
    public unsafe partial class AmdDrawBuffersBlend : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_draw_buffers_blend";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD mode)
            => ImplBlendEquationIndexed(buf, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD modeRGB, [Flow(FlowDirection.In)] AMD modeAlpha)
            => ImplBlendEquationSeparateIndexed(buf, modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="src">
        /// To be added.
        /// </param>
        /// <param name="dst">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD src, [Flow(FlowDirection.In)] AMD dst)
            => ImplBlendFuncIndexed(buf, src, dst);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="srcRGB">
        /// To be added.
        /// </param>
        /// <param name="dstRGB">
        /// To be added.
        /// </param>
        /// <param name="srcAlpha">
        /// To be added.
        /// </param>
        /// <param name="dstAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] AMD srcRGB, [Flow(FlowDirection.In)] AMD dstRGB, [Flow(FlowDirection.In)] AMD srcAlpha, [Flow(FlowDirection.In)] AMD dstAlpha)
            => ImplBlendFuncSeparateIndexed(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode)
            => ImplBlendEquationIndexed(buf, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparateIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha)
            => ImplBlendEquationSeparateIndexed(buf, modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="srcRGB">
        /// To be added.
        /// </param>
        /// <param name="dstRGB">
        /// To be added.
        /// </param>
        /// <param name="srcAlpha">
        /// To be added.
        /// </param>
        /// <param name="dstAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparateIndexedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparateIndexed([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha)
            => ImplBlendFuncSeparateIndexed(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        public AmdDrawBuffersBlend(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

