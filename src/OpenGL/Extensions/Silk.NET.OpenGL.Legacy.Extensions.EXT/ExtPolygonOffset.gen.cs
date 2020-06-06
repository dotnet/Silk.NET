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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_polygon_offset")]
    public unsafe partial class ExtPolygonOffset : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_polygon_offset";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="bias">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPolygonOffsetEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float bias)
            => ImplPolygonOffset(factor, bias);

        public ExtPolygonOffset(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

