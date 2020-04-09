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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_parallel_shader_compile")]
    public abstract unsafe partial class ArbParallelShaderCompile : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsARB")]
        public abstract void MaxShaderCompilerThreads([Flow(FlowDirection.In)] uint count);

        public ArbParallelShaderCompile(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

