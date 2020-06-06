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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_depth_buffer_float")]
    public unsafe partial class NVDepthBufferFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_depth_buffer_float";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glClearDepthdNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ClearDepth([Flow(FlowDirection.In)] double depth)
            => ImplClearDepth(depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="zmin">
        /// To be added.
        /// </param>
        /// <param name="zmax">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthBoundsdNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthBounds([Flow(FlowDirection.In)] double zmin, [Flow(FlowDirection.In)] double zmax)
            => ImplDepthBounds(zmin, zmax);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="zNear">
        /// To be added.
        /// </param>
        /// <param name="zFar">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDepthRangedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DepthRange([Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar)
            => ImplDepthRange(zNear, zFar);

        public NVDepthBufferFloat(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

