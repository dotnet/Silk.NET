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
    [Extension("ARB_compute_variable_group_size")]
    public abstract unsafe partial class ArbComputeVariableGroupSize : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_variable_group_size";
        [NativeApi(EntryPoint = "glDispatchComputeGroupSizeARB")]
        public abstract void DispatchComputeGroupSize([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z, [Flow(FlowDirection.In)] uint group_size_x, [Flow(FlowDirection.In)] uint group_size_y, [Flow(FlowDirection.In)] uint group_size_z);

        public ArbComputeVariableGroupSize(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

