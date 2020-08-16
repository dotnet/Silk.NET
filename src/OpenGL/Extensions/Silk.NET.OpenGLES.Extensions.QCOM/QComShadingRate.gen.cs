// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_shading_rate")]
    public unsafe partial class QComShadingRate : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_shading_rate";
        [NativeApi(EntryPoint = "glShadingRateQCOM")]
        public partial void ShadingRate([Flow(FlowDirection.In)] QCOM rate);

        [NativeApi(EntryPoint = "glShadingRateQCOM")]
        public partial void ShadingRate([Flow(FlowDirection.In)] ShadingRateQCOM rate);

        public QComShadingRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

