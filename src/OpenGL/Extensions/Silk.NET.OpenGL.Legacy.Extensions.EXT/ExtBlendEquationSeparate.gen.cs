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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_equation_separate")]
    public abstract unsafe partial class ExtBlendEquationSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_equation_separate";
        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparateEXT")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        public ExtBlendEquationSeparate(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

