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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_triangle_list")]
    public abstract unsafe partial class SunTriangleList : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeuiSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] uint code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeusSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] ushort code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeubSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] byte code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] uint* code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref uint code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ushort* code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref ushort code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] byte* code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref byte code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] string code);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged;

        public SunTriangleList(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

