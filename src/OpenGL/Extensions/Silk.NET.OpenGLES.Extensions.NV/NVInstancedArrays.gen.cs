// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_instanced_arrays")]
    public abstract unsafe partial class NVInstancedArrays : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribDivisorNV")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public NVInstancedArrays(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

