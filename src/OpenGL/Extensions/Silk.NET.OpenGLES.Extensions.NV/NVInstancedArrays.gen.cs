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
    [Extension("NV_instanced_arrays")]
    public unsafe partial class NVInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorNV")]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public NVInstancedArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

