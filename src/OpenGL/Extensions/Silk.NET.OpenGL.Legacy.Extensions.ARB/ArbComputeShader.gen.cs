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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_compute_shader")]
    public unsafe partial class ArbComputeShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_shader";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="num_groups_x">
        /// To be added.
        /// </param>
        /// <param name="num_groups_y">
        /// To be added.
        /// </param>
        /// <param name="num_groups_z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDispatchCompute")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z)
            => ImplDispatchCompute(num_groups_x, num_groups_y, num_groups_z);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect)
            => ImplDispatchComputeIndirect(indirect);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="indirect">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        public ArbComputeShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

