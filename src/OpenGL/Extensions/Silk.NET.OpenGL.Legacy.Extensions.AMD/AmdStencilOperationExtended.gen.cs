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
    [Extension("AMD_stencil_operation_extended")]
    public unsafe partial class AmdStencilOperationExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_stencil_operation_extended";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOpValueAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOpValue([Flow(FlowDirection.In)] AMD face, [Flow(FlowDirection.In)] uint value)
            => ImplStencilOpValue(face, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glStencilOpValueAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StencilOpValue([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint value)
            => ImplStencilOpValue(face, value);

        public AmdStencilOperationExtended(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

