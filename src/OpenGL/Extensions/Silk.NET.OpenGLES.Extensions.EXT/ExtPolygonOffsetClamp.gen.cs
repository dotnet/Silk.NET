// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_polygon_offset_clamp")]
    public unsafe partial class ExtPolygonOffsetClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_polygon_offset_clamp";
        [NativeApi(EntryPoint = "glPolygonOffsetClampEXT")]
        public partial void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp);

        public ExtPolygonOffsetClamp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

