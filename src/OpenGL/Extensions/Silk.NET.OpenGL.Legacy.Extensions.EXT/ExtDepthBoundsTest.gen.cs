// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_depth_bounds_test")]
    public unsafe partial class ExtDepthBoundsTest : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_depth_bounds_test";
        [NativeApi(EntryPoint = "glDepthBoundsEXT")]
        public partial void DepthBounds([Flow(FlowDirection.In)] double zmin, [Flow(FlowDirection.In)] double zmax);

        public ExtDepthBoundsTest(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

