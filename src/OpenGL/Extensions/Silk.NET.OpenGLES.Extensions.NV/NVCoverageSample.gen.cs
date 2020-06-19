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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_coverage_sample")]
    public abstract unsafe partial class NVCoverageSample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_coverage_sample";
        [NativeApi(EntryPoint = "glCoverageMaskNV")]
        public abstract void CoverageMask([Flow(FlowDirection.In)] bool mask);

        [NativeApi(EntryPoint = "glCoverageOperationNV")]
        public abstract void CoverageOperation([Flow(FlowDirection.In)] NV operation);

        public NVCoverageSample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

