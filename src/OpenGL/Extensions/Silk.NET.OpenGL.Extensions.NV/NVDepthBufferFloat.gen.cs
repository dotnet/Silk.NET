// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_depth_buffer_float")]
    public unsafe partial class NVDepthBufferFloat : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_depth_buffer_float";
        [NativeApi(EntryPoint = "glClearDepthdNV")]
        public partial void ClearDepth([Flow(FlowDirection.In)] double depth);

        [NativeApi(EntryPoint = "glDepthBoundsdNV")]
        public partial void DepthBounds([Flow(FlowDirection.In)] double zmin, [Flow(FlowDirection.In)] double zmax);

        [NativeApi(EntryPoint = "glDepthRangedNV")]
        public partial void DepthRange([Flow(FlowDirection.In)] double zNear, [Flow(FlowDirection.In)] double zFar);

        public NVDepthBufferFloat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

