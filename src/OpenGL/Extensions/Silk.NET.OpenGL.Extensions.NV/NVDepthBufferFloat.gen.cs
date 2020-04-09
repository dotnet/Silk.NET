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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_depth_buffer_float")]
    public abstract unsafe partial class NVDepthBufferFloat : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearDepthdNV")]
        public abstract void ClearDepth([Flow(FlowDirection.In)] double depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthBoundsdNV")]
        public abstract void DepthBounds([Flow(FlowDirection.In)] double zmin, [Flow(FlowDirection.In)] double zmax);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDepthRangedNV")]
        public abstract void DepthRange([Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        public NVDepthBufferFloat(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

