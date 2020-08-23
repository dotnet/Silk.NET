// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_pixel_data_range")]
    public unsafe partial class NVPixelDataRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_pixel_data_range";
        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV")]
        public partial void FlushPixelDataRange([Flow(FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV")]
        public partial void FlushPixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target);

        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public unsafe partial void PixelDataRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public partial void PixelDataRange<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public unsafe partial void PixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public partial void PixelDataRange<T0>([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public NVPixelDataRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

