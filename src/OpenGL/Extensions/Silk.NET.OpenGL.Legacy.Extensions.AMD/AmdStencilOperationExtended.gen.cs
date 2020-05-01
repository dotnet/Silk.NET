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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_stencil_operation_extended")]
    public abstract unsafe partial class AmdStencilOperationExtended : NativeExtension<GL>
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
        public abstract void StencilOpValue([Flow(FlowDirection.In)] AMD face, [Flow(FlowDirection.In)] uint value);

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
        public abstract void StencilOpValue([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint value);

        public AmdStencilOperationExtended(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

