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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_multisample")]
    public unsafe partial class SgisMultisample : NativeExtension<GL>
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert)
            => ImplSampleMask(value, invert);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplePattern([Flow(FlowDirection.In)] SGIS pattern)
            => ImplSamplePattern(pattern);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pattern">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SamplePattern([Flow(FlowDirection.In)] SamplePatternSGIS pattern)
            => ImplSamplePattern(pattern);

        public SgisMultisample(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

