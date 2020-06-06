// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    [Extension("KHR_parallel_shader_compile")]
    public unsafe partial class KhrParallelShaderCompile : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_parallel_shader_compile";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMaxShaderCompilerThreadsKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MaxShaderCompilerThreads([Flow(FlowDirection.In)] uint count)
            => ImplMaxShaderCompilerThreads(count);

        public KhrParallelShaderCompile(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

