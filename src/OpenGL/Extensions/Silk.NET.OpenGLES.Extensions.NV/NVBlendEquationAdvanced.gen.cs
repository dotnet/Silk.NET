// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_blend_equation_advanced")]
    public unsafe partial class NVBlendEquationAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_blend_equation_advanced";
        [NativeApi(EntryPoint = "glBlendBarrierNV")]
        public partial void BlendBarrier();

        [NativeApi(EntryPoint = "glBlendParameteriNV")]
        public partial void BlendParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value);

        public NVBlendEquationAdvanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

