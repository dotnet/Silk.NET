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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_instanced_arrays")]
    public abstract unsafe partial class ArbInstancedArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_instanced_arrays";
        [NativeApi(EntryPoint = "glVertexAttribDivisorARB")]
        public abstract void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        public ArbInstancedArrays(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

