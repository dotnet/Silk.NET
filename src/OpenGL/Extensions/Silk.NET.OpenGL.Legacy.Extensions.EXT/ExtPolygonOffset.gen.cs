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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_polygon_offset")]
    public abstract unsafe partial class ExtPolygonOffset : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPolygonOffsetEXT")]
        public abstract void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float bias);

        public ExtPolygonOffset(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

