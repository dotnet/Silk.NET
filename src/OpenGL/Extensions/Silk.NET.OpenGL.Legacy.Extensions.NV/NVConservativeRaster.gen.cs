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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_conservative_raster")]
    public abstract unsafe partial class NVConservativeRaster : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSubpixelPrecisionBiasNV")]
        public abstract void SubpixelPrecisionBias([Flow(FlowDirection.In)] uint xbits, [Flow(FlowDirection.In)] uint ybits);

        public NVConservativeRaster(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

