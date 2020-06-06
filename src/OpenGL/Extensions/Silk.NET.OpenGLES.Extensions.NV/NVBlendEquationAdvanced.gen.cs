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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_blend_equation_advanced")]
    public unsafe partial class NVBlendEquationAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_blend_equation_advanced";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glBlendBarrierNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendBarrier()
            => ImplBlendBarrier();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBlendParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BlendParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value)
            => ImplBlendParameter(pname, value);

        public NVBlendEquationAdvanced(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

