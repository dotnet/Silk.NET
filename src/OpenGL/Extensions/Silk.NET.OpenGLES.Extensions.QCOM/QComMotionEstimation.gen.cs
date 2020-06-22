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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_motion_estimation")]
    public abstract unsafe partial class QComMotionEstimation : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_motion_estimation";
        [NativeApi(EntryPoint = "glTexEstimateMotionQCOM")]
        public abstract void TexEstimateMotion([Flow(FlowDirection.In)] uint @ref, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint output);

        [NativeApi(EntryPoint = "glTexEstimateMotionRegionsQCOM")]
        public abstract void TexEstimateMotionRegion([Flow(FlowDirection.In)] uint @ref, [Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint output, [Flow(FlowDirection.In)] uint mask);

        public QComMotionEstimation(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

