// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_buffers_indexed")]
    public unsafe partial class ExtDrawBuffersIndexed : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers_indexed";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT mode)
            => ImplBlendEquation(buf, mode);

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
        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha)
            => ImplBlendEquationSeparate(buf, modeRGB, modeAlpha);

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
        [NativeApi(EntryPoint = "glBlendFunciEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] EXT dst)
            => ImplBlendFunc(buf, src, dst);

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
        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha)
            => ImplBlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorMaskiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a)
            => ImplColorMask(index, r, g, b, a);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplDisable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplEnable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnablediEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabled(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buf">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode)
            => ImplBlendEquation(buf, mode);

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
        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha)
            => ImplBlendEquationSeparate(buf, modeRGB, modeAlpha);

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
        [NativeApi(EntryPoint = "glBlendFunciEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst)
            => ImplBlendFunc(buf, src, dst);

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
        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha)
            => ImplBlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplDisable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableiEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplEnable(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnablediEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabled(target, index);

        public ExtDrawBuffersIndexed(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

