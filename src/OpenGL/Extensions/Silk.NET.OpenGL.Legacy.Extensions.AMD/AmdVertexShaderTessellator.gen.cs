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
    [Extension("AMD_vertex_shader_tessellator")]
    public abstract unsafe partial class AmdVertexShaderTessellator : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_vertex_shader_tessellator";
        [NativeApi(EntryPoint = "glTessellationFactorAMD")]
        public abstract void TessellationFactor([Flow(FlowDirection.In)] float factor);

        [NativeApi(EntryPoint = "glTessellationModeAMD")]
        public abstract void TessellationMode([Flow(FlowDirection.In)] AMD mode);

        public AmdVertexShaderTessellator(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

