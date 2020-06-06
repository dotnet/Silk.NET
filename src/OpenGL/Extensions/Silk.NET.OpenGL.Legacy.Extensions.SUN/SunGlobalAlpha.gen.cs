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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_global_alpha")]
    public unsafe partial class SunGlobalAlpha : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_global_alpha";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorbSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] sbyte factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactoriSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] int factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorfSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] float factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactordSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] double factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorubSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] byte factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorusSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] ushort factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactoruiSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactor([Flow(FlowDirection.In)] uint factor)
            => ImplObalAlphaFactor(factor);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGlobalAlphaFactorsSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ObalAlphaFactors([Flow(FlowDirection.In)] short factor)
            => ImplObalAlphaFactors(factor);

        public SunGlobalAlpha(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

