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
    [Extension("NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shading_rate_image";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindShadingRateImageNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindShadingRateImage([Flow(FlowDirection.In)] uint texture)
            => ImplBindShadingRateImage(texture);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] NV* rate)
            => ImplGetShadingRateImagePalette(viewport, entry, rate);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] out NV rate)
            => ImplGetShadingRateImagePalette(viewport, entry, rate);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] int* location)
            => ImplGetShadingRateSampleLocation(rate, samples, index, location);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] Span<int> location)
            => ImplGetShadingRateSampleLocation(rate, samples, index, location);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="synchronize">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShadingRateImageBarrier([Flow(FlowDirection.In)] bool synchronize)
            => ImplShadingRateImageBarrier(synchronize);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] NV* rates)
            => ImplShadingRateImagePalette(viewport, first, count, rates);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<NV> rates)
            => ImplShadingRateImagePalette(viewport, first, count, rates);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="order">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glShadingRateSampleOrderNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShadingRateSampleOrder([Flow(FlowDirection.In)] NV order)
            => ImplShadingRateSampleOrder(order);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] int* locations)
            => ImplShadingRateSampleOrderCustom(rate, samples, locations);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] ref int locations)
            => ImplShadingRateSampleOrderCustom(rate, samples, locations);

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

