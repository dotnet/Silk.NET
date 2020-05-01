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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_multisample")]
    public abstract unsafe partial class SgisMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_multisample";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="invert">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleMaskSGIS")]
        public abstract void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        public abstract void SamplePattern([Flow(FlowDirection.In)] SGIS pattern);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        public abstract void SamplePattern([Flow(FlowDirection.In)] SamplePatternSGIS pattern);

        public SgisMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

