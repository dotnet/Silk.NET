// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_conservative_raster_dilate")]
    public unsafe partial class NVConservativeRasterDilate : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster_dilate";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glConservativeRasterParameterfNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ConservativeRasterParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] float value)
            => ImplConservativeRasterParameter(pname, value);

        public NVConservativeRasterDilate(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

