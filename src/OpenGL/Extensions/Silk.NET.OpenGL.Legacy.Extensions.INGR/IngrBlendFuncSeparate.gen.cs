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

namespace Silk.NET.OpenGL.Legacy.Extensions.INGR
{
    [Extension("INGR_blend_func_separate")]
    public unsafe partial class IngrBlendFuncSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "INGR_blend_func_separate";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="dfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="sfactorAlpha">
        /// To be added.
        /// </param>
        /// <param name="dfactorAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] INGR sfactorRGB, [Flow(FlowDirection.In)] INGR dfactorRGB, [Flow(FlowDirection.In)] INGR sfactorAlpha, [Flow(FlowDirection.In)] INGR dfactorAlpha)
            => ImplBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="sfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="dfactorRGB">
        /// To be added.
        /// </param>
        /// <param name="sfactorAlpha">
        /// To be added.
        /// </param>
        /// <param name="dfactorAlpha">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha)
            => ImplBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);

        public IngrBlendFuncSeparate(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

