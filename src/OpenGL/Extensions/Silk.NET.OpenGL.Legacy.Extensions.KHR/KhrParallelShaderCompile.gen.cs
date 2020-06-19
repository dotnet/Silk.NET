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

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    [Extension("KHR_parallel_shader_compile")]
    public abstract unsafe partial class KhrParallelShaderCompile : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_parallel_shader_compile";
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsKHR")]
        public abstract void MaxShaderCompilerThreads([Flow(FlowDirection.In)] uint count);

        public KhrParallelShaderCompile(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

