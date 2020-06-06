// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_shader_storage_buffer_object")]
    public unsafe partial class ArbShaderStorageBufferObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_storage_buffer_object";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="storageBlockIndex">
        /// To be added.
        /// </param>
        /// <param name="storageBlockBinding">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShaderStorageBlockBinding")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShaderStorageBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint storageBlockIndex, [Flow(FlowDirection.In)] uint storageBlockBinding)
            => ImplShaderStorageBlockBinding(program, storageBlockIndex, storageBlockBinding);

        public ArbShaderStorageBufferObject(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

