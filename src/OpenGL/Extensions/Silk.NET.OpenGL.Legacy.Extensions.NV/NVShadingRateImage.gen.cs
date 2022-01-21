// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shading_rate_image";
        [NativeApi(EntryPoint = "glBindShadingRateImageNV", Convention = CallingConvention.Winapi)]
        public partial void BindShadingRateImage([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] NV* rate);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public partial void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] out NV rate);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV", Convention = CallingConvention.Winapi)]
        public partial void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateImageBarrier([Flow(FlowDirection.In)] bool synchronize);

        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateImageBarrier([Flow(FlowDirection.In)] Boolean synchronize);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] NV* rates);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in NV rates);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateSampleOrder([Flow(FlowDirection.In)] NV order);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] int* locations);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] in int locations);

        public unsafe void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<NV> rates)
        {
            // ImplicitCountSpanOverloader
            ShadingRateImagePalette(viewport, first, (uint) rates.Length, in rates.GetPinnableReference());
        }

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

