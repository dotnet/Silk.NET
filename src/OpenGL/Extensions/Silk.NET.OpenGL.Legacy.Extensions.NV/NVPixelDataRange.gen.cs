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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_pixel_data_range")]
    public abstract unsafe partial class NVPixelDataRange : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV")]
        public abstract void FlushPixelDataRange([Flow(FlowDirection.In)] NV target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public abstract unsafe void PixelDataRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public abstract void PixelDataRange<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV")]
        public abstract void FlushPixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public abstract unsafe void PixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glPixelDataRangeNV")]
        public abstract void PixelDataRange<T0>([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<T0> pointer) where T0 : unmanaged;

        public NVPixelDataRange(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

