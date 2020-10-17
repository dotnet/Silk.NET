// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_shading_rate_image")]
    public unsafe partial class NVShadingRateImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_shading_rate_image";
        [NativeApi(EntryPoint = "glBindShadingRateImageNV")]
        public partial void BindShadingRateImage([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV")]
        public unsafe partial void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] NV* rate);

        [NativeApi(EntryPoint = "glGetShadingRateImagePaletteNV")]
        public partial void GetShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] out NV rate);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV")]
        public unsafe partial void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] int* location);

        [NativeApi(EntryPoint = "glGetShadingRateSampleLocationivNV")]
        public partial void GetShadingRateSampleLocation([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] out int location);

        [NativeApi(EntryPoint = "glShadingRateImageBarrierNV")]
        public partial void ShadingRateImageBarrier([Flow(FlowDirection.In)] bool synchronize);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV")]
        public unsafe partial void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] NV* rates);

        [NativeApi(EntryPoint = "glShadingRateImagePaletteNV")]
        public partial void ShadingRateImagePalette([Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in NV rates);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderNV")]
        public partial void ShadingRateSampleOrder([Flow(FlowDirection.In)] NV order);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV")]
        public unsafe partial void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] int* locations);

        [NativeApi(EntryPoint = "glShadingRateSampleOrderCustomNV")]
        public partial void ShadingRateSampleOrderCustom([Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] in int locations);

        public NVShadingRateImage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

