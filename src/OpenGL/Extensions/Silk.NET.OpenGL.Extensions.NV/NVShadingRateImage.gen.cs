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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shading_rate_image";
        [NativeApi(EntryPoint = "glBindShadingRateImageNV", Convention = CallingConvention.Winapi)]
        public partial void BindShadingRateImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint entry, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] NV* rate);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public partial void GetShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint entry, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out NV rate);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetShadingRateSampleLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV", Convention = CallingConvention.Winapi)]
        public partial void GetShadingRateSampleLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateImageBarrier([Flow(Silk.NET.Core.Native.FlowDirection.In)] bool synchronize);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] NV* rates);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in NV rates);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateSampleOrder([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV order);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void ShadingRateSampleOrderCustom([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* locations);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV", Convention = CallingConvention.Winapi)]
        public partial void ShadingRateSampleOrderCustom([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int locations);

        public unsafe void ShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> rates)
        {
            // ImplicitCountSpanOverloader
            ShadingRateImagePalette(viewport, first, (uint) rates.Length, in rates.GetPinnableReference());
        }

        public unsafe NV GetShadingRateImagePalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint entry)
        {
            // NonKhrReturnTypeOverloader
            GetShadingRateImagePalette(viewport, entry, out NV silkRet);
            return silkRet;
        }

        public unsafe int GetShadingRateSampleLocation([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetShadingRateSampleLocation(rate, samples, index, out int silkRet);
            return silkRet;
        }

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

