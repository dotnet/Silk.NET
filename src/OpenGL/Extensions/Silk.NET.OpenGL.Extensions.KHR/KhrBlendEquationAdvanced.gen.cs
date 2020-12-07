// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.KHR
{
    [Extension("KHR_blend_equation_advanced")]
    public unsafe partial class KhrBlendEquationAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_blend_equation_advanced";
        [NativeApi(EntryPoint = "glBlendBarrierKHR")]
        public partial void BlendBarrier();

        public KhrBlendEquationAdvanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

