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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_equation_separate")]
    public unsafe partial class ExtBlendEquationSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_equation_separate";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha)
            => ImplBlendEquationSeparate(modeRGB, modeAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="modeRGB">
        /// To be added.
        /// </param>
        /// <param name="modeAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha)
            => ImplBlendEquationSeparate(modeRGB, modeAlpha);

        public ExtBlendEquationSeparate(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

