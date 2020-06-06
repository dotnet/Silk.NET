// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_framebuffer_mixed_samples")]
    public unsafe partial class NVFramebufferMixedSamples : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_mixed_samples";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageModulationNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverageModulation([Flow(FlowDirection.In)] NV components)
            => ImplCoverageModulation(components);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* v)
            => ImplCoverageModulationTable(n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> v)
            => ImplCoverageModulationTable(n, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v)
            => ImplGetCoverageModulationTable(bufSize, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v)
            => ImplGetCoverageModulationTable(bufSize, v);

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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe float GetCoverageModulationTable()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetCoverageModulationTable(bufSize, &ret);
            return ret;
        }

        public NVFramebufferMixedSamples(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

