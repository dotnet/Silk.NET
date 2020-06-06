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
    [Extension("NV_conservative_raster_pre_snap_triangles")]
    public unsafe partial class NVConservativeRasterPreSnapTriangles : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster_pre_snap_triangles";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="param">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glConservativeRasterParameteriNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConservativeRasterParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param)
            => ImplConservativeRasterParameter(pname, param);

        public NVConservativeRasterPreSnapTriangles(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

