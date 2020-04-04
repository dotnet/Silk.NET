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

namespace Silk.NET.OpenGL.Legacy.Extensions.INGR
{
    [Extension("INGR_blend_func_separate")]
    public abstract unsafe partial class IngrBlendFuncSeparate : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] INGR sfactorRGB, [Flow(FlowDirection.In)] INGR dfactorRGB, [Flow(FlowDirection.In)] INGR sfactorAlpha, [Flow(FlowDirection.In)] INGR dfactorAlpha);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        public IngrBlendFuncSeparate(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

