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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_compute_shader")]
    public abstract unsafe partial class ArbComputeShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_shader";
        [NativeApi(EntryPoint = "glDispatchCompute")]
        public abstract void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public abstract void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        public unsafe void DispatchComputeIndirect([Flow(FlowDirection.In)] int indirect)
        {
            // IntPtrOverloader
            DispatchComputeIndirect(new IntPtr(indirect));
        }

        public ArbComputeShader(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

