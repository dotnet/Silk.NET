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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_conservative_raster")]
    public abstract unsafe partial class NVConservativeRaster : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_conservative_raster";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xbits">
        /// To be added.
        /// </param>
        /// <param name="ybits">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSubpixelPrecisionBiasNV")]
        public abstract void SubpixelPrecisionBias([Flow(FlowDirection.In)] uint xbits, [Flow(FlowDirection.In)] uint ybits);

        public NVConservativeRaster(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

