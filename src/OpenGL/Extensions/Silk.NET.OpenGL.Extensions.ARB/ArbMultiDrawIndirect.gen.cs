// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_multi_draw_indirect")]
    public abstract unsafe partial class ArbMultiDrawIndirect : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        public ArbMultiDrawIndirect(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

