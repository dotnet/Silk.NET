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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_framebuffer_mixed_samples")]
    public abstract unsafe partial class NVFramebufferMixedSamples : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_mixed_samples";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="components">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCoverageModulationNV")]
        public abstract void CoverageModulation([Flow(FlowDirection.In)] NV components);

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
        public abstract unsafe void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* v);

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
        public abstract void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> v);

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
        public abstract unsafe void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

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
        public abstract void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

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

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        public unsafe float GetCoverageModulationTable()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetCoverageModulationTable(bufSize, &ret);
            return ret;
        }

        public NVFramebufferMixedSamples(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

