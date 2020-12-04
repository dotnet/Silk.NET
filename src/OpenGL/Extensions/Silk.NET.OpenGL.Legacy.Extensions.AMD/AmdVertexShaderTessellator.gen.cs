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
    [Extension("AMD_vertex_shader_tessellator")]
    public unsafe partial class AmdVertexShaderTessellator : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_vertex_shader_tessellator";
        [NativeApi(EntryPoint = "glTessellationFactorAMD")]
        public partial void TessellationFactor([Flow(FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glTessellationModeAMD")]
        public partial void TessellationMode([Flow(FlowDirection.In)] AMD mode);

        public AmdVertexShaderTessellator(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

