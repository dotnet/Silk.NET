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
    [Extension("NV_shading_rate_image")]
    public abstract unsafe partial class NVShadingRateImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shading_rate_image";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindShadingRateImageNV")]
        public abstract void BindShadingRateImage([Flow(FlowDirection.In)] uint texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="viewport">
        /// To be added.
        /// </param>
        /// <param name="entry">
        /// To be added.
        /// </param>
        /// <param name="rate">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV")]
        public abstract unsafe void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] NV* rate);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="viewport">
        /// To be added.
        /// </param>
        /// <param name="entry">
        /// To be added.
        /// </param>
        /// <param name="rate">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV")]
        public abstract void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] out NV rate);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rate">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV")]
        public abstract unsafe void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] int* location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rate">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="location">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV")]
        public abstract void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] Span<int> location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="synchronize">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV")]
        public abstract void ShadingRateImageBarrier([Flow(FlowDirection.In)] bool synchronize);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="viewport">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="rates">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV")]
        public abstract unsafe void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] NV* rates);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="viewport">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="rates">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV")]
        public abstract void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<NV> rates);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="order">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateSampleOrderNV")]
        public abstract void ShadingRateSampleOrder([Flow(FlowDirection.In)] NV order);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rate">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="locations">
        /// To be added.
        /// This parameter's element count is computed from rate and samples.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV")]
        public abstract unsafe void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] int* locations);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="rate">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="locations">
        /// To be added.
        /// This parameter's element count is computed from rate and samples.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV")]
        public abstract void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] ref int locations);

        public NVShadingRateImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

