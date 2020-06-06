// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_coverage_sample")]
    public unsafe partial class NVCoverageSample : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_coverage_sample";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageMaskNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverageMask([Flow(FlowDirection.In)] bool mask)
            => ImplCoverageMask(mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="operation">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageOperationNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverageOperation([Flow(FlowDirection.In)] NV operation)
            => ImplCoverageOperation(operation);

        public NVCoverageSample(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

