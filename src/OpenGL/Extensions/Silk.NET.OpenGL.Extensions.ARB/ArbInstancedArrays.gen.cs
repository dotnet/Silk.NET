// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_instanced_arrays")]
    public unsafe partial class ArbInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorARB")]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public ArbInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

