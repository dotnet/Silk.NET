// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_raster_multisample")]
    public abstract unsafe partial class ExtRasterMultisample : NativeExtension<GL>
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
        public abstract void RasterSamples([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public ExtRasterMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

