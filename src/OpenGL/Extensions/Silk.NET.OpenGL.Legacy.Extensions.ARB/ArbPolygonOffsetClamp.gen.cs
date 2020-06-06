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
    [Extension("ARB_polygon_offset_clamp")]
    public unsafe partial class ArbPolygonOffsetClamp : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_polygon_offset_clamp";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="factor">
        /// To be added.
        /// </param>
        /// <param name="units">
        /// To be added.
        /// </param>
        /// <param name="clamp">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPolygonOffsetClamp")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PolygonOffsetClamp([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units, [Flow(FlowDirection.In)] float clamp)
            => ImplPolygonOffsetClamp(factor, units, clamp);

        public ArbPolygonOffsetClamp(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

