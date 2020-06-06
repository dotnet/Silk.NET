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
    [Extension("EXT_raster_multisample")]
    public unsafe partial class ExtRasterMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_raster_multisample";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="fixedsamplelocations">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRasterSamplesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RasterSamples([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] bool fixedsamplelocations)
            => ImplRasterSamples(samples, fixedsamplelocations);

        public ExtRasterMultisample(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

