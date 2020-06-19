// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_scissor_exclusive")]
    public abstract unsafe partial class NVScissorExclusive : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_scissor_exclusive";
        [NativeApi(EntryPoint = "glScissorExclusiveNV")]
        public abstract void ScissorExclusive([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV")]
        public abstract unsafe void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glScissorExclusiveArrayvNV")]
        public abstract void ScissorExclusiveArray([Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        public NVScissorExclusive(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

