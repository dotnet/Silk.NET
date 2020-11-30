// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_compute_shader")]
    public unsafe partial class ArbComputeShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_shader";
        [NativeApi(EntryPoint = "glDispatchCompute")]
        public partial void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public partial void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        public ArbComputeShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

