// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_multisample")]
    public unsafe partial class SgisMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_multisample";
        [NativeApi(EntryPoint = "glSampleMaskSGIS")]
        public partial void SampleMask([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        public partial void SamplePattern([Flow(FlowDirection.In)] SGIS pattern);

        [NativeApi(EntryPoint = "glSamplePatternSGIS")]
        public partial void SamplePattern([Flow(FlowDirection.In)] SamplePatternSGIS pattern);

        public SgisMultisample(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

