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
    [Extension("ARB_compute_variable_group_size")]
    public unsafe partial class ArbComputeVariableGroupSize : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_compute_variable_group_size";
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
        /// <param name="group_size_x">
        /// To be added.
        /// </param>
        /// <param name="group_size_y">
        /// To be added.
        /// </param>
        /// <param name="group_size_z">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDispatchComputeGroupSizeARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DispatchComputeGroupSize([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z, [Flow(FlowDirection.In)] uint group_size_x, [Flow(FlowDirection.In)] uint group_size_y, [Flow(FlowDirection.In)] uint group_size_z)
            => ImplDispatchComputeGroupSize(num_groups_x, num_groups_y, num_groups_z, group_size_x, group_size_y, group_size_z);

        public ArbComputeVariableGroupSize(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

