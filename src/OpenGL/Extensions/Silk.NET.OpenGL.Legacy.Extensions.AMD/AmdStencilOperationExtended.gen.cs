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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_stencil_operation_extended")]
    public unsafe partial class AmdStencilOperationExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_stencil_operation_extended";
        [NativeApi(EntryPoint = "glStencilOpValueAMD")]
        public partial void StencilOpValue([Flow(FlowDirection.In)] AMD face, [Flow(FlowDirection.In)] uint value);

        [NativeApi(EntryPoint = "glStencilOpValueAMD")]
        public partial void StencilOpValue([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint value);

        public AmdStencilOperationExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

